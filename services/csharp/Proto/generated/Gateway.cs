// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: gateway/gateway.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Improbable.OnlineServices.Proto.Gateway {

  /// <summary>Holder for reflection information generated from gateway/gateway.proto</summary>
  public static partial class GatewayReflection {

    #region Descriptor
    /// <summary>File descriptor for gateway/gateway.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GatewayReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVnYXRld2F5L2dhdGV3YXkucHJvdG8SB2dhdGV3YXkaHGdvb2dsZS9hcGkv",
            "YW5ub3RhdGlvbnMucHJvdG8iqAEKC0pvaW5SZXF1ZXN0EhgKEG1hdGNobWFr",
            "aW5nX3R5cGUYASABKAkSNAoIbWV0YWRhdGEYAiADKAsyIi5nYXRld2F5Lkpv",
            "aW5SZXF1ZXN0Lk1ldGFkYXRhRW50cnkSGAoQbWF0Y2hfcmVxdWVzdF9pZBgD",
            "IAEoCRovCg1NZXRhZGF0YUVudHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgC",
            "IAEoCToCOAEiDgoMSm9pblJlc3BvbnNlIikKFEdldEpvaW5TdGF0dXNSZXF1",
            "ZXN0EhEKCXBsYXllcl9pZBgBIAEoCSLtAQoVR2V0Sm9pblN0YXR1c1Jlc3Bv",
            "bnNlEhAKCGNvbXBsZXRlGAEgASgIEjUKBnN0YXR1cxgCIAEoDjIlLmdhdGV3",
            "YXkuR2V0Sm9pblN0YXR1c1Jlc3BvbnNlLlN0YXR1cxITCgtsb2dpbl90b2tl",
            "bhgDIAEoCRIXCg9kZXBsb3ltZW50X25hbWUYBCABKAkSDQoFZXJyb3IYBSAB",
            "KAkiTgoGU3RhdHVzEhIKDlVOS05PV05fU1RBVFVTEAASCwoHV0FJVElORxAB",
            "EgwKCE1BVENISU5HEAISCgoGSk9JTkVEEAMSCQoFRVJST1IQBCImChFDYW5j",
            "ZWxKb2luUmVxdWVzdBIRCglwbGF5ZXJfaWQYASABKAkiFAoSQ2FuY2VsSm9p",
            "blJlc3BvbnNlMq0CCg5HYXRld2F5U2VydmljZRJICgRKb2luEhQuZ2F0ZXdh",
            "eS5Kb2luUmVxdWVzdBoVLmdhdGV3YXkuSm9pblJlc3BvbnNlIhOC0+STAg0i",
            "CC92MS9qb2luOgEqEm4KDUdldEpvaW5TdGF0dXMSHS5nYXRld2F5LkdldEpv",
            "aW5TdGF0dXNSZXF1ZXN0Gh4uZ2F0ZXdheS5HZXRKb2luU3RhdHVzUmVzcG9u",
            "c2UiHoLT5JMCGCITL3YxL2dldF9qb2luX3N0YXR1czoBKhJhCgpDYW5jZWxK",
            "b2luEhouZ2F0ZXdheS5DYW5jZWxKb2luUmVxdWVzdBobLmdhdGV3YXkuQ2Fu",
            "Y2VsSm9pblJlc3BvbnNlIhqC0+STAhQiDy92MS9jYW5jZWxfam9pbjoBKkIq",
            "qgInSW1wcm9iYWJsZS5PbmxpbmVTZXJ2aWNlcy5Qcm90by5HYXRld2F5YgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Improbable.OnlineServices.Proto.Gateway.JoinRequest), global::Improbable.OnlineServices.Proto.Gateway.JoinRequest.Parser, new[]{ "MatchmakingType", "Metadata", "MatchRequestId" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Improbable.OnlineServices.Proto.Gateway.JoinResponse), global::Improbable.OnlineServices.Proto.Gateway.JoinResponse.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Improbable.OnlineServices.Proto.Gateway.GetJoinStatusRequest), global::Improbable.OnlineServices.Proto.Gateway.GetJoinStatusRequest.Parser, new[]{ "PlayerId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Improbable.OnlineServices.Proto.Gateway.GetJoinStatusResponse), global::Improbable.OnlineServices.Proto.Gateway.GetJoinStatusResponse.Parser, new[]{ "Complete", "Status", "LoginToken", "DeploymentName", "Error" }, null, new[]{ typeof(global::Improbable.OnlineServices.Proto.Gateway.GetJoinStatusResponse.Types.Status) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Improbable.OnlineServices.Proto.Gateway.CancelJoinRequest), global::Improbable.OnlineServices.Proto.Gateway.CancelJoinRequest.Parser, new[]{ "PlayerId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Improbable.OnlineServices.Proto.Gateway.CancelJoinResponse), global::Improbable.OnlineServices.Proto.Gateway.CancelJoinResponse.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class JoinRequest : pb::IMessage<JoinRequest> {
    private static readonly pb::MessageParser<JoinRequest> _parser = new pb::MessageParser<JoinRequest>(() => new JoinRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<JoinRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Improbable.OnlineServices.Proto.Gateway.GatewayReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public JoinRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public JoinRequest(JoinRequest other) : this() {
      matchmakingType_ = other.matchmakingType_;
      metadata_ = other.metadata_.Clone();
      matchRequestId_ = other.matchRequestId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public JoinRequest Clone() {
      return new JoinRequest(this);
    }

    /// <summary>Field number for the "matchmaking_type" field.</summary>
    public const int MatchmakingTypeFieldNumber = 1;
    private string matchmakingType_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MatchmakingType {
      get { return matchmakingType_; }
      set {
        matchmakingType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 2;
    private static readonly pbc::MapField<string, string>.Codec _map_metadata_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 18);
    private readonly pbc::MapField<string, string> metadata_ = new pbc::MapField<string, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Metadata {
      get { return metadata_; }
    }

    /// <summary>Field number for the "match_request_id" field.</summary>
    public const int MatchRequestIdFieldNumber = 3;
    private string matchRequestId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MatchRequestId {
      get { return matchRequestId_; }
      set {
        matchRequestId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as JoinRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(JoinRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MatchmakingType != other.MatchmakingType) return false;
      if (!Metadata.Equals(other.Metadata)) return false;
      if (MatchRequestId != other.MatchRequestId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MatchmakingType.Length != 0) hash ^= MatchmakingType.GetHashCode();
      hash ^= Metadata.GetHashCode();
      if (MatchRequestId.Length != 0) hash ^= MatchRequestId.GetHashCode();
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
      if (MatchmakingType.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MatchmakingType);
      }
      metadata_.WriteTo(output, _map_metadata_codec);
      if (MatchRequestId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(MatchRequestId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MatchmakingType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MatchmakingType);
      }
      size += metadata_.CalculateSize(_map_metadata_codec);
      if (MatchRequestId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MatchRequestId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(JoinRequest other) {
      if (other == null) {
        return;
      }
      if (other.MatchmakingType.Length != 0) {
        MatchmakingType = other.MatchmakingType;
      }
      metadata_.Add(other.metadata_);
      if (other.MatchRequestId.Length != 0) {
        MatchRequestId = other.MatchRequestId;
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
          case 10: {
            MatchmakingType = input.ReadString();
            break;
          }
          case 18: {
            metadata_.AddEntriesFrom(input, _map_metadata_codec);
            break;
          }
          case 26: {
            MatchRequestId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class JoinResponse : pb::IMessage<JoinResponse> {
    private static readonly pb::MessageParser<JoinResponse> _parser = new pb::MessageParser<JoinResponse>(() => new JoinResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<JoinResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Improbable.OnlineServices.Proto.Gateway.GatewayReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public JoinResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public JoinResponse(JoinResponse other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public JoinResponse Clone() {
      return new JoinResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as JoinResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(JoinResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(JoinResponse other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  public sealed partial class GetJoinStatusRequest : pb::IMessage<GetJoinStatusRequest> {
    private static readonly pb::MessageParser<GetJoinStatusRequest> _parser = new pb::MessageParser<GetJoinStatusRequest>(() => new GetJoinStatusRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetJoinStatusRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Improbable.OnlineServices.Proto.Gateway.GatewayReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetJoinStatusRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetJoinStatusRequest(GetJoinStatusRequest other) : this() {
      playerId_ = other.playerId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetJoinStatusRequest Clone() {
      return new GetJoinStatusRequest(this);
    }

    /// <summary>Field number for the "player_id" field.</summary>
    public const int PlayerIdFieldNumber = 1;
    private string playerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PlayerId {
      get { return playerId_; }
      set {
        playerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetJoinStatusRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetJoinStatusRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerId != other.PlayerId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerId.Length != 0) hash ^= PlayerId.GetHashCode();
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
      if (PlayerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PlayerId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PlayerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PlayerId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetJoinStatusRequest other) {
      if (other == null) {
        return;
      }
      if (other.PlayerId.Length != 0) {
        PlayerId = other.PlayerId;
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
          case 10: {
            PlayerId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetJoinStatusResponse : pb::IMessage<GetJoinStatusResponse> {
    private static readonly pb::MessageParser<GetJoinStatusResponse> _parser = new pb::MessageParser<GetJoinStatusResponse>(() => new GetJoinStatusResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetJoinStatusResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Improbable.OnlineServices.Proto.Gateway.GatewayReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetJoinStatusResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetJoinStatusResponse(GetJoinStatusResponse other) : this() {
      complete_ = other.complete_;
      status_ = other.status_;
      loginToken_ = other.loginToken_;
      deploymentName_ = other.deploymentName_;
      error_ = other.error_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetJoinStatusResponse Clone() {
      return new GetJoinStatusResponse(this);
    }

    /// <summary>Field number for the "complete" field.</summary>
    public const int CompleteFieldNumber = 1;
    private bool complete_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Complete {
      get { return complete_; }
      set {
        complete_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 2;
    private global::Improbable.OnlineServices.Proto.Gateway.GetJoinStatusResponse.Types.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Improbable.OnlineServices.Proto.Gateway.GetJoinStatusResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "login_token" field.</summary>
    public const int LoginTokenFieldNumber = 3;
    private string loginToken_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LoginToken {
      get { return loginToken_; }
      set {
        loginToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "deployment_name" field.</summary>
    public const int DeploymentNameFieldNumber = 4;
    private string deploymentName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeploymentName {
      get { return deploymentName_; }
      set {
        deploymentName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 5;
    private string error_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Error {
      get { return error_; }
      set {
        error_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetJoinStatusResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetJoinStatusResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Complete != other.Complete) return false;
      if (Status != other.Status) return false;
      if (LoginToken != other.LoginToken) return false;
      if (DeploymentName != other.DeploymentName) return false;
      if (Error != other.Error) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Complete != false) hash ^= Complete.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
      if (LoginToken.Length != 0) hash ^= LoginToken.GetHashCode();
      if (DeploymentName.Length != 0) hash ^= DeploymentName.GetHashCode();
      if (Error.Length != 0) hash ^= Error.GetHashCode();
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
      if (Complete != false) {
        output.WriteRawTag(8);
        output.WriteBool(Complete);
      }
      if (Status != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Status);
      }
      if (LoginToken.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LoginToken);
      }
      if (DeploymentName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DeploymentName);
      }
      if (Error.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Error);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Complete != false) {
        size += 1 + 1;
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (LoginToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LoginToken);
      }
      if (DeploymentName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeploymentName);
      }
      if (Error.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Error);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetJoinStatusResponse other) {
      if (other == null) {
        return;
      }
      if (other.Complete != false) {
        Complete = other.Complete;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.LoginToken.Length != 0) {
        LoginToken = other.LoginToken;
      }
      if (other.DeploymentName.Length != 0) {
        DeploymentName = other.DeploymentName;
      }
      if (other.Error.Length != 0) {
        Error = other.Error;
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
            Complete = input.ReadBool();
            break;
          }
          case 16: {
            Status = (global::Improbable.OnlineServices.Proto.Gateway.GetJoinStatusResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 26: {
            LoginToken = input.ReadString();
            break;
          }
          case 34: {
            DeploymentName = input.ReadString();
            break;
          }
          case 42: {
            Error = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the GetJoinStatusResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("UNKNOWN_STATUS")] UnknownStatus = 0,
        [pbr::OriginalName("WAITING")] Waiting = 1,
        [pbr::OriginalName("MATCHING")] Matching = 2,
        [pbr::OriginalName("JOINED")] Joined = 3,
        [pbr::OriginalName("ERROR")] Error = 4,
      }

    }
    #endregion

  }

  public sealed partial class CancelJoinRequest : pb::IMessage<CancelJoinRequest> {
    private static readonly pb::MessageParser<CancelJoinRequest> _parser = new pb::MessageParser<CancelJoinRequest>(() => new CancelJoinRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CancelJoinRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Improbable.OnlineServices.Proto.Gateway.GatewayReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CancelJoinRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CancelJoinRequest(CancelJoinRequest other) : this() {
      playerId_ = other.playerId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CancelJoinRequest Clone() {
      return new CancelJoinRequest(this);
    }

    /// <summary>Field number for the "player_id" field.</summary>
    public const int PlayerIdFieldNumber = 1;
    private string playerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PlayerId {
      get { return playerId_; }
      set {
        playerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CancelJoinRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CancelJoinRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerId != other.PlayerId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerId.Length != 0) hash ^= PlayerId.GetHashCode();
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
      if (PlayerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PlayerId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PlayerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PlayerId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CancelJoinRequest other) {
      if (other == null) {
        return;
      }
      if (other.PlayerId.Length != 0) {
        PlayerId = other.PlayerId;
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
          case 10: {
            PlayerId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CancelJoinResponse : pb::IMessage<CancelJoinResponse> {
    private static readonly pb::MessageParser<CancelJoinResponse> _parser = new pb::MessageParser<CancelJoinResponse>(() => new CancelJoinResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CancelJoinResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Improbable.OnlineServices.Proto.Gateway.GatewayReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CancelJoinResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CancelJoinResponse(CancelJoinResponse other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CancelJoinResponse Clone() {
      return new CancelJoinResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CancelJoinResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CancelJoinResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CancelJoinResponse other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
