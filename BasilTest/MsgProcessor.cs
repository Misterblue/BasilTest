// Copyright 2018 Robert Adams
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

using Google.Protobuf;

using BasilType = org.herbal3d.basil.protocol.BasilType;
using BasilMessage = org.herbal3d.basil.protocol.Message;

namespace org.herbal3d.BasilTest {
    public abstract class MsgProcessor {

        private static readonly string _logHeader = "[MsgProcessor]";

        private Random _randomNumbers = new Random();
        protected BasilConnection _basilConnection;

        public MsgProcessor(BasilConnection pConnection) {
            _basilConnection = pConnection;
        }

        // Send a message and expect a RPC type response.
        protected async Task<BasilMessage.BasilMessage> SendAndPromiseResponse(BasilMessage.BasilMessage pReq) {
            // Place structure in message that receiver will send back so we can match response.
            UInt32 thisSession = (UInt32)_randomNumbers.Next();
            pReq.Response = new BasilType.BResponseRequest() {
                ResponseSession = thisSession
            };
            var tcs = new TaskCompletionSource<BasilMessage.BasilMessage>();
            lock (_basilConnection.OutstandingRPC) {
                _basilConnection.OutstandingRPC.Add(thisSession, new BasilConnection.SentRPC() {
                    session = thisSession,
                    context = this,
                    taskCompletion = tcs,
                    timeRPCCreated = (ulong)DateTime.UtcNow.ToBinary(),
                    requestName = _basilConnection.BasilMessageNameByOp[pReq.Op]
                });
            }
            _basilConnection.Send(pReq.ToByteArray());
            BasilMessage.BasilMessage resp = await tcs.Task;
            if (resp.Exception != null) {
                throw new BasilException(resp.Exception.Reason, new Dictionary<string,string>(resp.Exception.Hints));
            }
            return resp;
        }

        // Construct enclosing stream message to send back to the Basil viewer.
        // Called with a constructed response message and the stream message with the request.
        // Add the response information to the response message so other side can match
        //     the response to the request.
        protected void SendMessage(BasilMessage.BasilMessage pResponseMsg, BasilMessage.BasilMessage pReqMsg) {
            string responseMsgName = _basilConnection.BasilMessageNameByOp[pResponseMsg.Op];
            // BasilTest.log.DebugFormat("{0} SendResponse: {1}", _logHeader, responseMsgName);

            BasilMessage.BasilMessage msg = new BasilMessage.BasilMessage();
            if (pReqMsg != null && pReqMsg.Response != null) {
                msg.Response = pReqMsg.Response;
            }
            _basilConnection.Send(msg.ToByteArray());
        }

        // Given a request messsage and a partial response message, add the response tagging formation
        //    to the response so the sender of the request can match the messages.
        protected void MakeMessageAResponse(ref BasilMessage.BasilMessage pResponseMsg,
                    BasilMessage.BasilMessage pRequestMsg) {
            if (pRequestMsg.Response != null) {
                pResponseMsg.Response = pRequestMsg.Response;
            }
        }

        // Received a response type message.
        // Find the matching RPC call info and call the process waiting for the response.
        protected BasilMessage.BasilMessage HandleResponse(BasilMessage.BasilMessage pResponseMsg) {
            if (pResponseMsg.Response != null) {
                if (pResponseMsg.Response.ResponseSession != 0) {
                    // Look up the session this response corresponds to
                    UInt32 sessionIndex = pResponseMsg.Response.ResponseSession;
                    BasilConnection.SentRPC session;
                    TaskCompletionSource<BasilMessage.BasilMessage> responseTask = null;
                    lock (_basilConnection.OutstandingRPC) {
                        if (_basilConnection.OutstandingRPC.ContainsKey(sessionIndex)) {
                            session = (BasilConnection.SentRPC)_basilConnection.OutstandingRPC[sessionIndex];
                            _basilConnection.OutstandingRPC.Remove(sessionIndex);
                            responseTask = session.taskCompletion;
                        }
                        else {
                            BasilTest.log.ErrorFormat("{0} missing RCP response key: {1}", _logHeader, sessionIndex);
                        }
                    }
                    if (responseTask != null) {
                        try {
                            // Setting the result will start up the process waiting on the task
                            responseTask.SetResult(pResponseMsg);
                        }
                        catch (Exception e) {
                            BasilTest.log.ErrorFormat("{0} Exception processing message: {1}",
                                            _logHeader, e);
                        }
                    }
                }
                else {
                    BasilTest.log.ErrorFormat("{0} ResponseReq.ResponseSession missing. Type={1}",
                                    _logHeader, _basilConnection.BasilMessageNameByOp[pResponseMsg.Op]);
                }
            }
            else {
                BasilTest.log.ErrorFormat("{0} Response without ResponseReq. Type={1}",
                                _logHeader, _basilConnection.BasilMessageNameByOp[pResponseMsg.Op]);
            }
            return null;    // responses don't have a response
        }
    }
}
