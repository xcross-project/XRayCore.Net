// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proxy/wireguard/config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Xray.Proxy.WireGuard {

  /// <summary>Holder for reflection information generated from proxy/wireguard/config.proto</summary>
  public static partial class ConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for proxy/wireguard/config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chxwcm94eS93aXJlZ3VhcmQvY29uZmlnLnByb3RvEhR4cmF5LnByb3h5Lndp",
            "cmVndWFyZCJzCgpQZWVyQ29uZmlnEhIKCnB1YmxpY19rZXkYASABKAkSFgoO",
            "cHJlX3NoYXJlZF9rZXkYAiABKAkSEAoIZW5kcG9pbnQYAyABKAkSEgoKa2Vl",
            "cF9hbGl2ZRgEIAEoDRITCgthbGxvd2VkX2lwcxgFIAMoCSLtAgoMRGV2aWNl",
            "Q29uZmlnEhIKCnNlY3JldF9rZXkYASABKAkSEAoIZW5kcG9pbnQYAiADKAkS",
            "LwoFcGVlcnMYAyADKAsyIC54cmF5LnByb3h5LndpcmVndWFyZC5QZWVyQ29u",
            "ZmlnEgsKA210dRgEIAEoBRITCgtudW1fd29ya2VycxgFIAEoBRIQCghyZXNl",
            "cnZlZBgGIAEoDBJKCg9kb21haW5fc3RyYXRlZ3kYByABKA4yMS54cmF5LnBy",
            "b3h5LndpcmVndWFyZC5EZXZpY2VDb25maWcuRG9tYWluU3RyYXRlZ3kSEQoJ",
            "aXNfY2xpZW50GAggASgIEhUKDW5vX2tlcm5lbF90dW4YCSABKAgiXAoORG9t",
            "YWluU3RyYXRlZ3kSDAoIRk9SQ0VfSVAQABINCglGT1JDRV9JUDQQARINCglG",
            "T1JDRV9JUDYQAhIOCgpGT1JDRV9JUDQ2EAMSDgoKRk9SQ0VfSVA2NBAEQl4K",
            "GGNvbS54cmF5LnByb3h5LndpcmVndWFyZFABWilnaXRodWIuY29tL3h0bHMv",
            "eHJheS1jb3JlL3Byb3h5L3dpcmVndWFyZKoCFFhyYXkuUHJveHkuV2lyZUd1",
            "YXJkYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Xray.Proxy.WireGuard.PeerConfig), global::Xray.Proxy.WireGuard.PeerConfig.Parser, new[]{ "PublicKey", "PreSharedKey", "Endpoint", "KeepAlive", "AllowedIps" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Xray.Proxy.WireGuard.DeviceConfig), global::Xray.Proxy.WireGuard.DeviceConfig.Parser, new[]{ "SecretKey", "Endpoint", "Peers", "Mtu", "NumWorkers", "Reserved", "DomainStrategy", "IsClient", "NoKernelTun" }, null, new[]{ typeof(global::Xray.Proxy.WireGuard.DeviceConfig.Types.DomainStrategy) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PeerConfig : pb::IMessage<PeerConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PeerConfig> _parser = new pb::MessageParser<PeerConfig>(() => new PeerConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PeerConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Xray.Proxy.WireGuard.ConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PeerConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PeerConfig(PeerConfig other) : this() {
      publicKey_ = other.publicKey_;
      preSharedKey_ = other.preSharedKey_;
      endpoint_ = other.endpoint_;
      keepAlive_ = other.keepAlive_;
      allowedIps_ = other.allowedIps_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PeerConfig Clone() {
      return new PeerConfig(this);
    }

    /// <summary>Field number for the "public_key" field.</summary>
    public const int PublicKeyFieldNumber = 1;
    private string publicKey_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PublicKey {
      get { return publicKey_; }
      set {
        publicKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pre_shared_key" field.</summary>
    public const int PreSharedKeyFieldNumber = 2;
    private string preSharedKey_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PreSharedKey {
      get { return preSharedKey_; }
      set {
        preSharedKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "endpoint" field.</summary>
    public const int EndpointFieldNumber = 3;
    private string endpoint_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Endpoint {
      get { return endpoint_; }
      set {
        endpoint_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "keep_alive" field.</summary>
    public const int KeepAliveFieldNumber = 4;
    private uint keepAlive_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KeepAlive {
      get { return keepAlive_; }
      set {
        keepAlive_ = value;
      }
    }

    /// <summary>Field number for the "allowed_ips" field.</summary>
    public const int AllowedIpsFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_allowedIps_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> allowedIps_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> AllowedIps {
      get { return allowedIps_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PeerConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PeerConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PublicKey != other.PublicKey) return false;
      if (PreSharedKey != other.PreSharedKey) return false;
      if (Endpoint != other.Endpoint) return false;
      if (KeepAlive != other.KeepAlive) return false;
      if(!allowedIps_.Equals(other.allowedIps_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PublicKey.Length != 0) hash ^= PublicKey.GetHashCode();
      if (PreSharedKey.Length != 0) hash ^= PreSharedKey.GetHashCode();
      if (Endpoint.Length != 0) hash ^= Endpoint.GetHashCode();
      if (KeepAlive != 0) hash ^= KeepAlive.GetHashCode();
      hash ^= allowedIps_.GetHashCode();
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
      if (PublicKey.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PublicKey);
      }
      if (PreSharedKey.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PreSharedKey);
      }
      if (Endpoint.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Endpoint);
      }
      if (KeepAlive != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(KeepAlive);
      }
      allowedIps_.WriteTo(output, _repeated_allowedIps_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (PublicKey.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PublicKey);
      }
      if (PreSharedKey.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PreSharedKey);
      }
      if (Endpoint.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Endpoint);
      }
      if (KeepAlive != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(KeepAlive);
      }
      allowedIps_.WriteTo(ref output, _repeated_allowedIps_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (PublicKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PublicKey);
      }
      if (PreSharedKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PreSharedKey);
      }
      if (Endpoint.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Endpoint);
      }
      if (KeepAlive != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KeepAlive);
      }
      size += allowedIps_.CalculateSize(_repeated_allowedIps_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PeerConfig other) {
      if (other == null) {
        return;
      }
      if (other.PublicKey.Length != 0) {
        PublicKey = other.PublicKey;
      }
      if (other.PreSharedKey.Length != 0) {
        PreSharedKey = other.PreSharedKey;
      }
      if (other.Endpoint.Length != 0) {
        Endpoint = other.Endpoint;
      }
      if (other.KeepAlive != 0) {
        KeepAlive = other.KeepAlive;
      }
      allowedIps_.Add(other.allowedIps_);
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            PublicKey = input.ReadString();
            break;
          }
          case 18: {
            PreSharedKey = input.ReadString();
            break;
          }
          case 26: {
            Endpoint = input.ReadString();
            break;
          }
          case 32: {
            KeepAlive = input.ReadUInt32();
            break;
          }
          case 42: {
            allowedIps_.AddEntriesFrom(input, _repeated_allowedIps_codec);
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            PublicKey = input.ReadString();
            break;
          }
          case 18: {
            PreSharedKey = input.ReadString();
            break;
          }
          case 26: {
            Endpoint = input.ReadString();
            break;
          }
          case 32: {
            KeepAlive = input.ReadUInt32();
            break;
          }
          case 42: {
            allowedIps_.AddEntriesFrom(ref input, _repeated_allowedIps_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DeviceConfig : pb::IMessage<DeviceConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DeviceConfig> _parser = new pb::MessageParser<DeviceConfig>(() => new DeviceConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DeviceConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Xray.Proxy.WireGuard.ConfigReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeviceConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeviceConfig(DeviceConfig other) : this() {
      secretKey_ = other.secretKey_;
      endpoint_ = other.endpoint_.Clone();
      peers_ = other.peers_.Clone();
      mtu_ = other.mtu_;
      numWorkers_ = other.numWorkers_;
      reserved_ = other.reserved_;
      domainStrategy_ = other.domainStrategy_;
      isClient_ = other.isClient_;
      noKernelTun_ = other.noKernelTun_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeviceConfig Clone() {
      return new DeviceConfig(this);
    }

    /// <summary>Field number for the "secret_key" field.</summary>
    public const int SecretKeyFieldNumber = 1;
    private string secretKey_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SecretKey {
      get { return secretKey_; }
      set {
        secretKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "endpoint" field.</summary>
    public const int EndpointFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_endpoint_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> endpoint_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Endpoint {
      get { return endpoint_; }
    }

    /// <summary>Field number for the "peers" field.</summary>
    public const int PeersFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Xray.Proxy.WireGuard.PeerConfig> _repeated_peers_codec
        = pb::FieldCodec.ForMessage(26, global::Xray.Proxy.WireGuard.PeerConfig.Parser);
    private readonly pbc::RepeatedField<global::Xray.Proxy.WireGuard.PeerConfig> peers_ = new pbc::RepeatedField<global::Xray.Proxy.WireGuard.PeerConfig>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Xray.Proxy.WireGuard.PeerConfig> Peers {
      get { return peers_; }
    }

    /// <summary>Field number for the "mtu" field.</summary>
    public const int MtuFieldNumber = 4;
    private int mtu_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Mtu {
      get { return mtu_; }
      set {
        mtu_ = value;
      }
    }

    /// <summary>Field number for the "num_workers" field.</summary>
    public const int NumWorkersFieldNumber = 5;
    private int numWorkers_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int NumWorkers {
      get { return numWorkers_; }
      set {
        numWorkers_ = value;
      }
    }

    /// <summary>Field number for the "reserved" field.</summary>
    public const int ReservedFieldNumber = 6;
    private pb::ByteString reserved_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Reserved {
      get { return reserved_; }
      set {
        reserved_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "domain_strategy" field.</summary>
    public const int DomainStrategyFieldNumber = 7;
    private global::Xray.Proxy.WireGuard.DeviceConfig.Types.DomainStrategy domainStrategy_ = global::Xray.Proxy.WireGuard.DeviceConfig.Types.DomainStrategy.ForceIp;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Xray.Proxy.WireGuard.DeviceConfig.Types.DomainStrategy DomainStrategy {
      get { return domainStrategy_; }
      set {
        domainStrategy_ = value;
      }
    }

    /// <summary>Field number for the "is_client" field.</summary>
    public const int IsClientFieldNumber = 8;
    private bool isClient_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsClient {
      get { return isClient_; }
      set {
        isClient_ = value;
      }
    }

    /// <summary>Field number for the "no_kernel_tun" field.</summary>
    public const int NoKernelTunFieldNumber = 9;
    private bool noKernelTun_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool NoKernelTun {
      get { return noKernelTun_; }
      set {
        noKernelTun_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DeviceConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DeviceConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SecretKey != other.SecretKey) return false;
      if(!endpoint_.Equals(other.endpoint_)) return false;
      if(!peers_.Equals(other.peers_)) return false;
      if (Mtu != other.Mtu) return false;
      if (NumWorkers != other.NumWorkers) return false;
      if (Reserved != other.Reserved) return false;
      if (DomainStrategy != other.DomainStrategy) return false;
      if (IsClient != other.IsClient) return false;
      if (NoKernelTun != other.NoKernelTun) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SecretKey.Length != 0) hash ^= SecretKey.GetHashCode();
      hash ^= endpoint_.GetHashCode();
      hash ^= peers_.GetHashCode();
      if (Mtu != 0) hash ^= Mtu.GetHashCode();
      if (NumWorkers != 0) hash ^= NumWorkers.GetHashCode();
      if (Reserved.Length != 0) hash ^= Reserved.GetHashCode();
      if (DomainStrategy != global::Xray.Proxy.WireGuard.DeviceConfig.Types.DomainStrategy.ForceIp) hash ^= DomainStrategy.GetHashCode();
      if (IsClient != false) hash ^= IsClient.GetHashCode();
      if (NoKernelTun != false) hash ^= NoKernelTun.GetHashCode();
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
      if (SecretKey.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SecretKey);
      }
      endpoint_.WriteTo(output, _repeated_endpoint_codec);
      peers_.WriteTo(output, _repeated_peers_codec);
      if (Mtu != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Mtu);
      }
      if (NumWorkers != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(NumWorkers);
      }
      if (Reserved.Length != 0) {
        output.WriteRawTag(50);
        output.WriteBytes(Reserved);
      }
      if (DomainStrategy != global::Xray.Proxy.WireGuard.DeviceConfig.Types.DomainStrategy.ForceIp) {
        output.WriteRawTag(56);
        output.WriteEnum((int) DomainStrategy);
      }
      if (IsClient != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsClient);
      }
      if (NoKernelTun != false) {
        output.WriteRawTag(72);
        output.WriteBool(NoKernelTun);
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
      if (SecretKey.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SecretKey);
      }
      endpoint_.WriteTo(ref output, _repeated_endpoint_codec);
      peers_.WriteTo(ref output, _repeated_peers_codec);
      if (Mtu != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Mtu);
      }
      if (NumWorkers != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(NumWorkers);
      }
      if (Reserved.Length != 0) {
        output.WriteRawTag(50);
        output.WriteBytes(Reserved);
      }
      if (DomainStrategy != global::Xray.Proxy.WireGuard.DeviceConfig.Types.DomainStrategy.ForceIp) {
        output.WriteRawTag(56);
        output.WriteEnum((int) DomainStrategy);
      }
      if (IsClient != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsClient);
      }
      if (NoKernelTun != false) {
        output.WriteRawTag(72);
        output.WriteBool(NoKernelTun);
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
      if (SecretKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SecretKey);
      }
      size += endpoint_.CalculateSize(_repeated_endpoint_codec);
      size += peers_.CalculateSize(_repeated_peers_codec);
      if (Mtu != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Mtu);
      }
      if (NumWorkers != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NumWorkers);
      }
      if (Reserved.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Reserved);
      }
      if (DomainStrategy != global::Xray.Proxy.WireGuard.DeviceConfig.Types.DomainStrategy.ForceIp) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DomainStrategy);
      }
      if (IsClient != false) {
        size += 1 + 1;
      }
      if (NoKernelTun != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DeviceConfig other) {
      if (other == null) {
        return;
      }
      if (other.SecretKey.Length != 0) {
        SecretKey = other.SecretKey;
      }
      endpoint_.Add(other.endpoint_);
      peers_.Add(other.peers_);
      if (other.Mtu != 0) {
        Mtu = other.Mtu;
      }
      if (other.NumWorkers != 0) {
        NumWorkers = other.NumWorkers;
      }
      if (other.Reserved.Length != 0) {
        Reserved = other.Reserved;
      }
      if (other.DomainStrategy != global::Xray.Proxy.WireGuard.DeviceConfig.Types.DomainStrategy.ForceIp) {
        DomainStrategy = other.DomainStrategy;
      }
      if (other.IsClient != false) {
        IsClient = other.IsClient;
      }
      if (other.NoKernelTun != false) {
        NoKernelTun = other.NoKernelTun;
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            SecretKey = input.ReadString();
            break;
          }
          case 18: {
            endpoint_.AddEntriesFrom(input, _repeated_endpoint_codec);
            break;
          }
          case 26: {
            peers_.AddEntriesFrom(input, _repeated_peers_codec);
            break;
          }
          case 32: {
            Mtu = input.ReadInt32();
            break;
          }
          case 40: {
            NumWorkers = input.ReadInt32();
            break;
          }
          case 50: {
            Reserved = input.ReadBytes();
            break;
          }
          case 56: {
            DomainStrategy = (global::Xray.Proxy.WireGuard.DeviceConfig.Types.DomainStrategy) input.ReadEnum();
            break;
          }
          case 64: {
            IsClient = input.ReadBool();
            break;
          }
          case 72: {
            NoKernelTun = input.ReadBool();
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            SecretKey = input.ReadString();
            break;
          }
          case 18: {
            endpoint_.AddEntriesFrom(ref input, _repeated_endpoint_codec);
            break;
          }
          case 26: {
            peers_.AddEntriesFrom(ref input, _repeated_peers_codec);
            break;
          }
          case 32: {
            Mtu = input.ReadInt32();
            break;
          }
          case 40: {
            NumWorkers = input.ReadInt32();
            break;
          }
          case 50: {
            Reserved = input.ReadBytes();
            break;
          }
          case 56: {
            DomainStrategy = (global::Xray.Proxy.WireGuard.DeviceConfig.Types.DomainStrategy) input.ReadEnum();
            break;
          }
          case 64: {
            IsClient = input.ReadBool();
            break;
          }
          case 72: {
            NoKernelTun = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the DeviceConfig message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum DomainStrategy {
        [pbr::OriginalName("FORCE_IP")] ForceIp = 0,
        [pbr::OriginalName("FORCE_IP4")] ForceIp4 = 1,
        [pbr::OriginalName("FORCE_IP6")] ForceIp6 = 2,
        [pbr::OriginalName("FORCE_IP46")] ForceIp46 = 3,
        [pbr::OriginalName("FORCE_IP64")] ForceIp64 = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
