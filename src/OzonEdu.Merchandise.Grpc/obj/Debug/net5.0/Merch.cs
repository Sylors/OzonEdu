// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: merch.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OzonEdu.Merchandise.Grpc {

  /// <summary>Holder for reflection information generated from merch.proto</summary>
  public static partial class MerchReflection {

    #region Descriptor
    /// <summary>File descriptor for merch.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MerchReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgttZXJjaC5wcm90bxIFTWVyY2gaG2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5w",
            "cm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJzLnByb3RvGh9nb29nbGUv",
            "cHJvdG9idWYvdGltZXN0YW1wLnByb3RvIioKE1JlcXVlc3RNZXJjaFJlcXVl",
            "c3QSEwoLZW1wbG95ZWVfaWQYASABKAMiNwogR2V0SW5mb0Fib3V0SXNzdWFu",
            "Y2VNZXJjaFJlcXVlc3QSEwoLZW1wbG95ZWVfaWQYASABKAMiYAohR2V0SW5m",
            "b0Fib3V0SXNzdWFuY2VNZXJjaFJlc3BvbnNlEjsKBXVuaXRzGAEgAygLMiwu",
            "TWVyY2guR2V0SW5mb0Fib3V0SXNzdWFuY2VNZXJjaFJlc3BvbnNlVW5pdCKc",
            "AQolR2V0SW5mb0Fib3V0SXNzdWFuY2VNZXJjaFJlc3BvbnNlVW5pdBIPCgdp",
            "dGVtX2lkGAEgASgDEi8KCWl0ZW1fbmFtZRgCIAEoCzIcLmdvb2dsZS5wcm90",
            "b2J1Zi5TdHJpbmdWYWx1ZRIxCg1kYXRlX29mX2lzc3VlGAMgASgLMhouZ29v",
            "Z2xlLnByb3RvYnVmLlRpbWVzdGFtcDK/AQoJTWVyY2hHcnBjEkIKDFJlcXVl",
            "c3RNZXJjaBIaLk1lcmNoLlJlcXVlc3RNZXJjaFJlcXVlc3QaFi5nb29nbGUu",
            "cHJvdG9idWYuRW1wdHkSbgoZR2V0SW5mb0Fib3V0SXNzdWFuY2VNZXJjaBIn",
            "Lk1lcmNoLkdldEluZm9BYm91dElzc3VhbmNlTWVyY2hSZXF1ZXN0GiguTWVy",
            "Y2guR2V0SW5mb0Fib3V0SXNzdWFuY2VNZXJjaFJlc3BvbnNlQhuqAhhPem9u",
            "RWR1Lk1lcmNoYW5kaXNlLkdycGNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OzonEdu.Merchandise.Grpc.RequestMerchRequest), global::OzonEdu.Merchandise.Grpc.RequestMerchRequest.Parser, new[]{ "EmployeeId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::OzonEdu.Merchandise.Grpc.GetInfoAboutIssuanceMerchRequest), global::OzonEdu.Merchandise.Grpc.GetInfoAboutIssuanceMerchRequest.Parser, new[]{ "EmployeeId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::OzonEdu.Merchandise.Grpc.GetInfoAboutIssuanceMerchResponse), global::OzonEdu.Merchandise.Grpc.GetInfoAboutIssuanceMerchResponse.Parser, new[]{ "Units" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::OzonEdu.Merchandise.Grpc.GetInfoAboutIssuanceMerchResponseUnit), global::OzonEdu.Merchandise.Grpc.GetInfoAboutIssuanceMerchResponseUnit.Parser, new[]{ "ItemId", "ItemName", "DateOfIssue" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RequestMerchRequest : pb::IMessage<RequestMerchRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RequestMerchRequest> _parser = new pb::MessageParser<RequestMerchRequest>(() => new RequestMerchRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RequestMerchRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OzonEdu.Merchandise.Grpc.MerchReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RequestMerchRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RequestMerchRequest(RequestMerchRequest other) : this() {
      employeeId_ = other.employeeId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RequestMerchRequest Clone() {
      return new RequestMerchRequest(this);
    }

    /// <summary>Field number for the "employee_id" field.</summary>
    public const int EmployeeIdFieldNumber = 1;
    private long employeeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long EmployeeId {
      get { return employeeId_; }
      set {
        employeeId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RequestMerchRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RequestMerchRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EmployeeId != other.EmployeeId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EmployeeId != 0L) hash ^= EmployeeId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (EmployeeId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(EmployeeId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (EmployeeId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(EmployeeId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (EmployeeId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(EmployeeId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RequestMerchRequest other) {
      if (other == null) {
        return;
      }
      if (other.EmployeeId != 0L) {
        EmployeeId = other.EmployeeId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            EmployeeId = input.ReadInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            EmployeeId = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class GetInfoAboutIssuanceMerchRequest : pb::IMessage<GetInfoAboutIssuanceMerchRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetInfoAboutIssuanceMerchRequest> _parser = new pb::MessageParser<GetInfoAboutIssuanceMerchRequest>(() => new GetInfoAboutIssuanceMerchRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetInfoAboutIssuanceMerchRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OzonEdu.Merchandise.Grpc.MerchReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetInfoAboutIssuanceMerchRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetInfoAboutIssuanceMerchRequest(GetInfoAboutIssuanceMerchRequest other) : this() {
      employeeId_ = other.employeeId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetInfoAboutIssuanceMerchRequest Clone() {
      return new GetInfoAboutIssuanceMerchRequest(this);
    }

    /// <summary>Field number for the "employee_id" field.</summary>
    public const int EmployeeIdFieldNumber = 1;
    private long employeeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long EmployeeId {
      get { return employeeId_; }
      set {
        employeeId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetInfoAboutIssuanceMerchRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetInfoAboutIssuanceMerchRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EmployeeId != other.EmployeeId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EmployeeId != 0L) hash ^= EmployeeId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (EmployeeId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(EmployeeId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (EmployeeId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(EmployeeId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (EmployeeId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(EmployeeId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetInfoAboutIssuanceMerchRequest other) {
      if (other == null) {
        return;
      }
      if (other.EmployeeId != 0L) {
        EmployeeId = other.EmployeeId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            EmployeeId = input.ReadInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            EmployeeId = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class GetInfoAboutIssuanceMerchResponse : pb::IMessage<GetInfoAboutIssuanceMerchResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetInfoAboutIssuanceMerchResponse> _parser = new pb::MessageParser<GetInfoAboutIssuanceMerchResponse>(() => new GetInfoAboutIssuanceMerchResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetInfoAboutIssuanceMerchResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OzonEdu.Merchandise.Grpc.MerchReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetInfoAboutIssuanceMerchResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetInfoAboutIssuanceMerchResponse(GetInfoAboutIssuanceMerchResponse other) : this() {
      units_ = other.units_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetInfoAboutIssuanceMerchResponse Clone() {
      return new GetInfoAboutIssuanceMerchResponse(this);
    }

    /// <summary>Field number for the "units" field.</summary>
    public const int UnitsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::OzonEdu.Merchandise.Grpc.GetInfoAboutIssuanceMerchResponseUnit> _repeated_units_codec
        = pb::FieldCodec.ForMessage(10, global::OzonEdu.Merchandise.Grpc.GetInfoAboutIssuanceMerchResponseUnit.Parser);
    private readonly pbc::RepeatedField<global::OzonEdu.Merchandise.Grpc.GetInfoAboutIssuanceMerchResponseUnit> units_ = new pbc::RepeatedField<global::OzonEdu.Merchandise.Grpc.GetInfoAboutIssuanceMerchResponseUnit>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OzonEdu.Merchandise.Grpc.GetInfoAboutIssuanceMerchResponseUnit> Units {
      get { return units_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetInfoAboutIssuanceMerchResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetInfoAboutIssuanceMerchResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!units_.Equals(other.units_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= units_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      units_.WriteTo(output, _repeated_units_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      units_.WriteTo(ref output, _repeated_units_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += units_.CalculateSize(_repeated_units_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetInfoAboutIssuanceMerchResponse other) {
      if (other == null) {
        return;
      }
      units_.Add(other.units_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            units_.AddEntriesFrom(input, _repeated_units_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            units_.AddEntriesFrom(ref input, _repeated_units_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class GetInfoAboutIssuanceMerchResponseUnit : pb::IMessage<GetInfoAboutIssuanceMerchResponseUnit>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetInfoAboutIssuanceMerchResponseUnit> _parser = new pb::MessageParser<GetInfoAboutIssuanceMerchResponseUnit>(() => new GetInfoAboutIssuanceMerchResponseUnit());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetInfoAboutIssuanceMerchResponseUnit> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OzonEdu.Merchandise.Grpc.MerchReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetInfoAboutIssuanceMerchResponseUnit() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetInfoAboutIssuanceMerchResponseUnit(GetInfoAboutIssuanceMerchResponseUnit other) : this() {
      itemId_ = other.itemId_;
      ItemName = other.ItemName;
      dateOfIssue_ = other.dateOfIssue_ != null ? other.dateOfIssue_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetInfoAboutIssuanceMerchResponseUnit Clone() {
      return new GetInfoAboutIssuanceMerchResponseUnit(this);
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 1;
    private long itemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "item_name" field.</summary>
    public const int ItemNameFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_itemName_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string itemName_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ItemName {
      get { return itemName_; }
      set {
        itemName_ = value;
      }
    }


    /// <summary>Field number for the "date_of_issue" field.</summary>
    public const int DateOfIssueFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp dateOfIssue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp DateOfIssue {
      get { return dateOfIssue_; }
      set {
        dateOfIssue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetInfoAboutIssuanceMerchResponseUnit);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetInfoAboutIssuanceMerchResponseUnit other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      if (ItemName != other.ItemName) return false;
      if (!object.Equals(DateOfIssue, other.DateOfIssue)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ItemId != 0L) hash ^= ItemId.GetHashCode();
      if (itemName_ != null) hash ^= ItemName.GetHashCode();
      if (dateOfIssue_ != null) hash ^= DateOfIssue.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ItemId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(ItemId);
      }
      if (itemName_ != null) {
        _single_itemName_codec.WriteTagAndValue(output, ItemName);
      }
      if (dateOfIssue_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(DateOfIssue);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ItemId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(ItemId);
      }
      if (itemName_ != null) {
        _single_itemName_codec.WriteTagAndValue(ref output, ItemName);
      }
      if (dateOfIssue_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(DateOfIssue);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ItemId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ItemId);
      }
      if (itemName_ != null) {
        size += _single_itemName_codec.CalculateSizeWithTag(ItemName);
      }
      if (dateOfIssue_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DateOfIssue);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetInfoAboutIssuanceMerchResponseUnit other) {
      if (other == null) {
        return;
      }
      if (other.ItemId != 0L) {
        ItemId = other.ItemId;
      }
      if (other.itemName_ != null) {
        if (itemName_ == null || other.ItemName != "") {
          ItemName = other.ItemName;
        }
      }
      if (other.dateOfIssue_ != null) {
        if (dateOfIssue_ == null) {
          DateOfIssue = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        DateOfIssue.MergeFrom(other.DateOfIssue);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ItemId = input.ReadInt64();
            break;
          }
          case 18: {
            string value = _single_itemName_codec.Read(input);
            if (itemName_ == null || value != "") {
              ItemName = value;
            }
            break;
          }
          case 26: {
            if (dateOfIssue_ == null) {
              DateOfIssue = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(DateOfIssue);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            ItemId = input.ReadInt64();
            break;
          }
          case 18: {
            string value = _single_itemName_codec.Read(ref input);
            if (itemName_ == null || value != "") {
              ItemName = value;
            }
            break;
          }
          case 26: {
            if (dateOfIssue_ == null) {
              DateOfIssue = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(DateOfIssue);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
