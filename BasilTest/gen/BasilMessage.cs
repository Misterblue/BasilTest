// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BasilMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace org.herbal3d.basil.protocol.Message {

  /// <summary>Holder for reflection information generated from BasilMessage.proto</summary>
  public static partial class BasilMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for BasilMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BasilMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJCYXNpbE1lc3NhZ2UucHJvdG8SDEJhc2lsTWVzc2FnZRoQQmFzaWxUeXBl",
            "cy5wcm90byKiBQoMQmFzaWxNZXNzYWdlEgoKAm9wGAEgASgFEiwKBGF1dGgY",
            "AiABKAsyHi5CYXNpbFR5cGUuQWNjZXNzQXV0aG9yaXphdGlvbhItCghvYmpl",
            "Y3RJZBgDIAEoCzIbLkJhc2lsVHlwZS5PYmplY3RJZGVudGlmaWVyEjEKCmlu",
            "c3RhbmNlSWQYBCABKAsyHS5CYXNpbFR5cGUuSW5zdGFuY2VJZGVudGlmaWVy",
            "EiwKA3BvcxgFIAEoCzIfLkJhc2lsVHlwZS5JbnN0YW5jZVBvc2l0aW9uSW5m",
            "bxIuCglhc3NldEluZm8YBiABKAsyGy5CYXNpbFR5cGUuQXNzZXRJbmZvcm1h",
            "dGlvbhImCgRhYWJiGAcgASgLMhguQmFzaWxUeXBlLkFhQm91bmRpbmdCb3gS",
            "DgoGZmlsdGVyGAggASgJEj4KCnByb3BlcnRpZXMYCSADKAsyKi5CYXNpbE1l",
            "c3NhZ2UuQmFzaWxNZXNzYWdlLlByb3BlcnRpZXNFbnRyeRJCCgxvcFBhcmFt",
            "ZXRlcnMYCiADKAsyLC5CYXNpbE1lc3NhZ2UuQmFzaWxNZXNzYWdlLk9wUGFy",
            "YW1ldGVyc0VudHJ5EiwKCWV4Y2VwdGlvbhgLIAEoCzIZLkJhc2lsVHlwZS5C",
            "YXNpbEV4Y2VwdGlvbhIXCg9leGNlcHRpb25SZWFzb24YDCABKAkSLQoIcmVz",
            "cG9uc2UYDSABKAsyGy5CYXNpbFR5cGUuQlJlc3BvbnNlUmVxdWVzdBoxCg9Q",
            "cm9wZXJ0aWVzRW50cnkSCwoDa2V5GAEgASgJEg0KBXZhbHVlGAIgASgJOgI4",
            "ARozChFPcFBhcmFtZXRlcnNFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUY",
            "AiABKAk6AjgBKskGCg9CYXNpbE1lc3NhZ2VPcHMSDgoKVW5rbm93blJlcRAA",
            "EiEKHElkZW50aWZ5RGlzcGxheWFibGVPYmplY3RSZXEQgSASIgodSWRlbnRp",
            "ZnlEaXNwbGF5YWJsZU9iamVjdFJlc3AQgiASHwoaRm9yZ2V0RGlzcGxheWFi",
            "bGVPYmplY3RSZXEQgyASIAobRm9yZ2V0RGlzcGxheWFibGVPYmplY3RSZXNw",
            "EIQgEhwKF0NyZWF0ZU9iamVjdEluc3RhbmNlUmVxEIUgEh0KGENyZWF0ZU9i",
            "amVjdEluc3RhbmNlUmVzcBCGIBIcChdEZWxldGVPYmplY3RJbnN0YW5jZVJl",
            "cRCHIBIdChhEZWxldGVPYmplY3RJbnN0YW5jZVJlc3AQiCASHAoXVXBkYXRl",
            "T2JqZWN0UHJvcGVydHlSZXEQiSASHQoYVXBkYXRlT2JqZWN0UHJvcGVydHlS",
            "ZXNwEIogEh4KGVVwZGF0ZUluc3RhbmNlUHJvcGVydHlSZXEQiyASHwoaVXBk",
            "YXRlSW5zdGFuY2VQcm9wZXJ0eVJlc3AQjCASHgoZVXBkYXRlSW5zdGFuY2VQ",
            "b3NpdGlvblJlcRCNIBIfChpVcGRhdGVJbnN0YW5jZVBvc2l0aW9uUmVzcBCO",
            "IBIfChpSZXF1ZXN0T2JqZWN0UHJvcGVydGllc1JlcRCPIBIgChtSZXF1ZXN0",
            "T2JqZWN0UHJvcGVydGllc1Jlc3AQkCASIQocUmVxdWVzdEluc3RhbmNlUHJv",
            "cGVydGllc1JlcRCRIBIiCh1SZXF1ZXN0SW5zdGFuY2VQcm9wZXJ0aWVzUmVz",
            "cBCSIBIUCg9DbG9zZVNlc3Npb25SZXEQkyASFQoQQ2xvc2VTZXNzaW9uUmVz",
            "cBCUIBIWChFNYWtlQ29ubmVjdGlvblJlcRCVIBIXChJNYWtlQ29ubmVjdGlv",
            "blJlc3AQliASEgoNQWxpdmVDaGVja1JlcRCBQBITCg5BbGl2ZUNoZWNrUmVz",
            "cBCCQBITCg5PcGVuU2Vzc2lvblJlcRCBYBIUCg9PcGVuU2Vzc2lvblJlc3AQ",
            "gmASEgoNQ2FtZXJhVmlld1JlcRCDYBITCg5DYW1lcmFWaWV3UmVzcBCEYEIm",
            "qgIjb3JnLmhlcmJhbDNkLmJhc2lsLnByb3RvY29sLk1lc3NhZ2ViBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::org.herbal3d.basil.protocol.BasilType.BasilTypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::org.herbal3d.basil.protocol.Message.BasilMessageOps), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::org.herbal3d.basil.protocol.Message.BasilMessage), global::org.herbal3d.basil.protocol.Message.BasilMessage.Parser, new[]{ "Op", "Auth", "ObjectId", "InstanceId", "Pos", "AssetInfo", "Aabb", "Filter", "Properties", "OpParameters", "Exception", "ExceptionReason", "Response" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// The operation codes that go into BasilMessage.op
  /// </summary>
  public enum BasilMessageOps {
    [pbr::OriginalName("UnknownReq")] UnknownReq = 0,
    [pbr::OriginalName("IdentifyDisplayableObjectReq")] IdentifyDisplayableObjectReq = 4097,
    [pbr::OriginalName("IdentifyDisplayableObjectResp")] IdentifyDisplayableObjectResp = 4098,
    [pbr::OriginalName("ForgetDisplayableObjectReq")] ForgetDisplayableObjectReq = 4099,
    [pbr::OriginalName("ForgetDisplayableObjectResp")] ForgetDisplayableObjectResp = 4100,
    [pbr::OriginalName("CreateObjectInstanceReq")] CreateObjectInstanceReq = 4101,
    [pbr::OriginalName("CreateObjectInstanceResp")] CreateObjectInstanceResp = 4102,
    [pbr::OriginalName("DeleteObjectInstanceReq")] DeleteObjectInstanceReq = 4103,
    [pbr::OriginalName("DeleteObjectInstanceResp")] DeleteObjectInstanceResp = 4104,
    [pbr::OriginalName("UpdateObjectPropertyReq")] UpdateObjectPropertyReq = 4105,
    [pbr::OriginalName("UpdateObjectPropertyResp")] UpdateObjectPropertyResp = 4106,
    [pbr::OriginalName("UpdateInstancePropertyReq")] UpdateInstancePropertyReq = 4107,
    [pbr::OriginalName("UpdateInstancePropertyResp")] UpdateInstancePropertyResp = 4108,
    [pbr::OriginalName("UpdateInstancePositionReq")] UpdateInstancePositionReq = 4109,
    [pbr::OriginalName("UpdateInstancePositionResp")] UpdateInstancePositionResp = 4110,
    [pbr::OriginalName("RequestObjectPropertiesReq")] RequestObjectPropertiesReq = 4111,
    [pbr::OriginalName("RequestObjectPropertiesResp")] RequestObjectPropertiesResp = 4112,
    [pbr::OriginalName("RequestInstancePropertiesReq")] RequestInstancePropertiesReq = 4113,
    [pbr::OriginalName("RequestInstancePropertiesResp")] RequestInstancePropertiesResp = 4114,
    [pbr::OriginalName("CloseSessionReq")] CloseSessionReq = 4115,
    [pbr::OriginalName("CloseSessionResp")] CloseSessionResp = 4116,
    [pbr::OriginalName("MakeConnectionReq")] MakeConnectionReq = 4117,
    [pbr::OriginalName("MakeConnectionResp")] MakeConnectionResp = 4118,
    /// <summary>
    /// AliveCheck ping/pong
    /// </summary>
    [pbr::OriginalName("AliveCheckReq")] AliveCheckReq = 8193,
    [pbr::OriginalName("AliveCheckResp")] AliveCheckResp = 8194,
    /// <summary>
    /// SpaceServer
    /// </summary>
    [pbr::OriginalName("OpenSessionReq")] OpenSessionReq = 12289,
    [pbr::OriginalName("OpenSessionResp")] OpenSessionResp = 12290,
    [pbr::OriginalName("CameraViewReq")] CameraViewReq = 12291,
    [pbr::OriginalName("CameraViewResp")] CameraViewResp = 12292,
  }

  #endregion

  #region Messages
  public sealed partial class BasilMessage : pb::IMessage<BasilMessage> {
    private static readonly pb::MessageParser<BasilMessage> _parser = new pb::MessageParser<BasilMessage>(() => new BasilMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BasilMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::org.herbal3d.basil.protocol.Message.BasilMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BasilMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BasilMessage(BasilMessage other) : this() {
      op_ = other.op_;
      Auth = other.auth_ != null ? other.Auth.Clone() : null;
      ObjectId = other.objectId_ != null ? other.ObjectId.Clone() : null;
      InstanceId = other.instanceId_ != null ? other.InstanceId.Clone() : null;
      Pos = other.pos_ != null ? other.Pos.Clone() : null;
      AssetInfo = other.assetInfo_ != null ? other.AssetInfo.Clone() : null;
      Aabb = other.aabb_ != null ? other.Aabb.Clone() : null;
      filter_ = other.filter_;
      properties_ = other.properties_.Clone();
      opParameters_ = other.opParameters_.Clone();
      Exception = other.exception_ != null ? other.Exception.Clone() : null;
      exceptionReason_ = other.exceptionReason_;
      Response = other.response_ != null ? other.Response.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BasilMessage Clone() {
      return new BasilMessage(this);
    }

    /// <summary>Field number for the "op" field.</summary>
    public const int OpFieldNumber = 1;
    private int op_;
    /// <summary>
    /// operation to perform
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Op {
      get { return op_; }
      set {
        op_ = value;
      }
    }

    /// <summary>Field number for the "auth" field.</summary>
    public const int AuthFieldNumber = 2;
    private global::org.herbal3d.basil.protocol.BasilType.AccessAuthorization auth_;
    /// <summary>
    /// authorization for op
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::org.herbal3d.basil.protocol.BasilType.AccessAuthorization Auth {
      get { return auth_; }
      set {
        auth_ = value;
      }
    }

    /// <summary>Field number for the "objectId" field.</summary>
    public const int ObjectIdFieldNumber = 3;
    private global::org.herbal3d.basil.protocol.BasilType.ObjectIdentifier objectId_;
    /// <summary>
    /// if op needs object reference
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::org.herbal3d.basil.protocol.BasilType.ObjectIdentifier ObjectId {
      get { return objectId_; }
      set {
        objectId_ = value;
      }
    }

    /// <summary>Field number for the "instanceId" field.</summary>
    public const int InstanceIdFieldNumber = 4;
    private global::org.herbal3d.basil.protocol.BasilType.InstanceIdentifier instanceId_;
    /// <summary>
    /// if of needs instance reference
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::org.herbal3d.basil.protocol.BasilType.InstanceIdentifier InstanceId {
      get { return instanceId_; }
      set {
        instanceId_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 5;
    private global::org.herbal3d.basil.protocol.BasilType.InstancePositionInfo pos_;
    /// <summary>
    /// if op needs a position spec
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::org.herbal3d.basil.protocol.BasilType.InstancePositionInfo Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "assetInfo" field.</summary>
    public const int AssetInfoFieldNumber = 6;
    private global::org.herbal3d.basil.protocol.BasilType.AssetInformation assetInfo_;
    /// <summary>
    /// if op needs asset info
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::org.herbal3d.basil.protocol.BasilType.AssetInformation AssetInfo {
      get { return assetInfo_; }
      set {
        assetInfo_ = value;
      }
    }

    /// <summary>Field number for the "aabb" field.</summary>
    public const int AabbFieldNumber = 7;
    private global::org.herbal3d.basil.protocol.BasilType.AaBoundingBox aabb_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::org.herbal3d.basil.protocol.BasilType.AaBoundingBox Aabb {
      get { return aabb_; }
      set {
        aabb_ = value;
      }
    }

    /// <summary>Field number for the "filter" field.</summary>
    public const int FilterFieldNumber = 8;
    private string filter_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Filter {
      get { return filter_; }
      set {
        filter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "properties" field.</summary>
    public const int PropertiesFieldNumber = 9;
    private static readonly pbc::MapField<string, string>.Codec _map_properties_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 74);
    private readonly pbc::MapField<string, string> properties_ = new pbc::MapField<string, string>();
    /// <summary>
    /// if op needs or returns property set
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Properties {
      get { return properties_; }
    }

    /// <summary>Field number for the "opParameters" field.</summary>
    public const int OpParametersFieldNumber = 10;
    private static readonly pbc::MapField<string, string>.Codec _map_opParameters_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 82);
    private readonly pbc::MapField<string, string> opParameters_ = new pbc::MapField<string, string>();
    /// <summary>
    /// other parameters needed by op
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> OpParameters {
      get { return opParameters_; }
    }

    /// <summary>Field number for the "exception" field.</summary>
    public const int ExceptionFieldNumber = 11;
    private global::org.herbal3d.basil.protocol.BasilType.BasilException exception_;
    /// <summary>
    /// if op is returning an error
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::org.herbal3d.basil.protocol.BasilType.BasilException Exception {
      get { return exception_; }
      set {
        exception_ = value;
      }
    }

    /// <summary>Field number for the "exceptionReason" field.</summary>
    public const int ExceptionReasonFieldNumber = 12;
    private string exceptionReason_ = "";
    /// <summary>
    /// readable info about exception
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ExceptionReason {
      get { return exceptionReason_; }
      set {
        exceptionReason_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "response" field.</summary>
    public const int ResponseFieldNumber = 13;
    private global::org.herbal3d.basil.protocol.BasilType.BResponseRequest response_;
    /// <summary>
    /// transport RPC information
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::org.herbal3d.basil.protocol.BasilType.BResponseRequest Response {
      get { return response_; }
      set {
        response_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BasilMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BasilMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Op != other.Op) return false;
      if (!object.Equals(Auth, other.Auth)) return false;
      if (!object.Equals(ObjectId, other.ObjectId)) return false;
      if (!object.Equals(InstanceId, other.InstanceId)) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (!object.Equals(AssetInfo, other.AssetInfo)) return false;
      if (!object.Equals(Aabb, other.Aabb)) return false;
      if (Filter != other.Filter) return false;
      if (!Properties.Equals(other.Properties)) return false;
      if (!OpParameters.Equals(other.OpParameters)) return false;
      if (!object.Equals(Exception, other.Exception)) return false;
      if (ExceptionReason != other.ExceptionReason) return false;
      if (!object.Equals(Response, other.Response)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Op != 0) hash ^= Op.GetHashCode();
      if (auth_ != null) hash ^= Auth.GetHashCode();
      if (objectId_ != null) hash ^= ObjectId.GetHashCode();
      if (instanceId_ != null) hash ^= InstanceId.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (assetInfo_ != null) hash ^= AssetInfo.GetHashCode();
      if (aabb_ != null) hash ^= Aabb.GetHashCode();
      if (Filter.Length != 0) hash ^= Filter.GetHashCode();
      hash ^= Properties.GetHashCode();
      hash ^= OpParameters.GetHashCode();
      if (exception_ != null) hash ^= Exception.GetHashCode();
      if (ExceptionReason.Length != 0) hash ^= ExceptionReason.GetHashCode();
      if (response_ != null) hash ^= Response.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Op != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Op);
      }
      if (auth_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Auth);
      }
      if (objectId_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ObjectId);
      }
      if (instanceId_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(InstanceId);
      }
      if (pos_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Pos);
      }
      if (assetInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(AssetInfo);
      }
      if (aabb_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Aabb);
      }
      if (Filter.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Filter);
      }
      properties_.WriteTo(output, _map_properties_codec);
      opParameters_.WriteTo(output, _map_opParameters_codec);
      if (exception_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Exception);
      }
      if (ExceptionReason.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(ExceptionReason);
      }
      if (response_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Response);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Op != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Op);
      }
      if (auth_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Auth);
      }
      if (objectId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ObjectId);
      }
      if (instanceId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InstanceId);
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (assetInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AssetInfo);
      }
      if (aabb_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Aabb);
      }
      if (Filter.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Filter);
      }
      size += properties_.CalculateSize(_map_properties_codec);
      size += opParameters_.CalculateSize(_map_opParameters_codec);
      if (exception_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Exception);
      }
      if (ExceptionReason.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ExceptionReason);
      }
      if (response_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Response);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BasilMessage other) {
      if (other == null) {
        return;
      }
      if (other.Op != 0) {
        Op = other.Op;
      }
      if (other.auth_ != null) {
        if (auth_ == null) {
          auth_ = new global::org.herbal3d.basil.protocol.BasilType.AccessAuthorization();
        }
        Auth.MergeFrom(other.Auth);
      }
      if (other.objectId_ != null) {
        if (objectId_ == null) {
          objectId_ = new global::org.herbal3d.basil.protocol.BasilType.ObjectIdentifier();
        }
        ObjectId.MergeFrom(other.ObjectId);
      }
      if (other.instanceId_ != null) {
        if (instanceId_ == null) {
          instanceId_ = new global::org.herbal3d.basil.protocol.BasilType.InstanceIdentifier();
        }
        InstanceId.MergeFrom(other.InstanceId);
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          pos_ = new global::org.herbal3d.basil.protocol.BasilType.InstancePositionInfo();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.assetInfo_ != null) {
        if (assetInfo_ == null) {
          assetInfo_ = new global::org.herbal3d.basil.protocol.BasilType.AssetInformation();
        }
        AssetInfo.MergeFrom(other.AssetInfo);
      }
      if (other.aabb_ != null) {
        if (aabb_ == null) {
          aabb_ = new global::org.herbal3d.basil.protocol.BasilType.AaBoundingBox();
        }
        Aabb.MergeFrom(other.Aabb);
      }
      if (other.Filter.Length != 0) {
        Filter = other.Filter;
      }
      properties_.Add(other.properties_);
      opParameters_.Add(other.opParameters_);
      if (other.exception_ != null) {
        if (exception_ == null) {
          exception_ = new global::org.herbal3d.basil.protocol.BasilType.BasilException();
        }
        Exception.MergeFrom(other.Exception);
      }
      if (other.ExceptionReason.Length != 0) {
        ExceptionReason = other.ExceptionReason;
      }
      if (other.response_ != null) {
        if (response_ == null) {
          response_ = new global::org.herbal3d.basil.protocol.BasilType.BResponseRequest();
        }
        Response.MergeFrom(other.Response);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Op = input.ReadInt32();
            break;
          }
          case 18: {
            if (auth_ == null) {
              auth_ = new global::org.herbal3d.basil.protocol.BasilType.AccessAuthorization();
            }
            input.ReadMessage(auth_);
            break;
          }
          case 26: {
            if (objectId_ == null) {
              objectId_ = new global::org.herbal3d.basil.protocol.BasilType.ObjectIdentifier();
            }
            input.ReadMessage(objectId_);
            break;
          }
          case 34: {
            if (instanceId_ == null) {
              instanceId_ = new global::org.herbal3d.basil.protocol.BasilType.InstanceIdentifier();
            }
            input.ReadMessage(instanceId_);
            break;
          }
          case 42: {
            if (pos_ == null) {
              pos_ = new global::org.herbal3d.basil.protocol.BasilType.InstancePositionInfo();
            }
            input.ReadMessage(pos_);
            break;
          }
          case 50: {
            if (assetInfo_ == null) {
              assetInfo_ = new global::org.herbal3d.basil.protocol.BasilType.AssetInformation();
            }
            input.ReadMessage(assetInfo_);
            break;
          }
          case 58: {
            if (aabb_ == null) {
              aabb_ = new global::org.herbal3d.basil.protocol.BasilType.AaBoundingBox();
            }
            input.ReadMessage(aabb_);
            break;
          }
          case 66: {
            Filter = input.ReadString();
            break;
          }
          case 74: {
            properties_.AddEntriesFrom(input, _map_properties_codec);
            break;
          }
          case 82: {
            opParameters_.AddEntriesFrom(input, _map_opParameters_codec);
            break;
          }
          case 90: {
            if (exception_ == null) {
              exception_ = new global::org.herbal3d.basil.protocol.BasilType.BasilException();
            }
            input.ReadMessage(exception_);
            break;
          }
          case 98: {
            ExceptionReason = input.ReadString();
            break;
          }
          case 106: {
            if (response_ == null) {
              response_ = new global::org.herbal3d.basil.protocol.BasilType.BResponseRequest();
            }
            input.ReadMessage(response_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
