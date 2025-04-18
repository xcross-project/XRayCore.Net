// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: transport/internet/reality/config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Xray.Transport.Internet.Reality {

  /// <summary>Holder for reflection information generated from transport/internet/reality/config.proto</summary>
  public static partial class ConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for transport/internet/reality/config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cid0cmFuc3BvcnQvaW50ZXJuZXQvcmVhbGl0eS9jb25maWcucHJvdG8SH3hy",
            "YXkudHJhbnNwb3J0LmludGVybmV0LnJlYWxpdHki0QIKBkNvbmZpZxIMCgRz",
            "aG93GAEgASgIEgwKBGRlc3QYAiABKAkSDAoEdHlwZRgDIAEoCRIMCgR4dmVy",
            "GAQgASgEEhQKDHNlcnZlcl9uYW1lcxgFIAMoCRITCgtwcml2YXRlX2tleRgG",
            "IAEoDBIWCg5taW5fY2xpZW50X3ZlchgHIAEoDBIWCg5tYXhfY2xpZW50X3Zl",
            "chgIIAEoDBIVCg1tYXhfdGltZV9kaWZmGAkgASgEEhEKCXNob3J0X2lkcxgK",
            "IAMoDBITCgtGaW5nZXJwcmludBgVIAEoCRITCgtzZXJ2ZXJfbmFtZRgWIAEo",
            "CRISCgpwdWJsaWNfa2V5GBcgASgMEhAKCHNob3J0X2lkGBggASgMEhAKCHNw",
            "aWRlcl94GBkgASgJEhAKCHNwaWRlcl95GBogAygDEhYKDm1hc3Rlcl9rZXlf",
            "bG9nGBsgASgJQn8KI2NvbS54cmF5LnRyYW5zcG9ydC5pbnRlcm5ldC5yZWFs",
            "aXR5UAFaNGdpdGh1Yi5jb20veHRscy94cmF5LWNvcmUvdHJhbnNwb3J0L2lu",
            "dGVybmV0L3JlYWxpdHmqAh9YcmF5LlRyYW5zcG9ydC5JbnRlcm5ldC5SZWFs",
            "aXR5YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Xray.Transport.Internet.Reality.Config), global::Xray.Transport.Internet.Reality.Config.Parser, new[]{ "Show", "Dest", "Type", "Xver", "ServerNames", "PrivateKey", "MinClientVer", "MaxClientVer", "MaxTimeDiff", "ShortIds", "Fingerprint", "ServerName", "PublicKey", "ShortId", "SpiderX", "SpiderY", "MasterKeyLog" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Config : pb::IMessage<Config>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Config> _parser = new pb::MessageParser<Config>(() => new Config());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Config> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Xray.Transport.Internet.Reality.ConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Config() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Config(Config other) : this() {
      show_ = other.show_;
      dest_ = other.dest_;
      type_ = other.type_;
      xver_ = other.xver_;
      serverNames_ = other.serverNames_.Clone();
      privateKey_ = other.privateKey_;
      minClientVer_ = other.minClientVer_;
      maxClientVer_ = other.maxClientVer_;
      maxTimeDiff_ = other.maxTimeDiff_;
      shortIds_ = other.shortIds_.Clone();
      fingerprint_ = other.fingerprint_;
      serverName_ = other.serverName_;
      publicKey_ = other.publicKey_;
      shortId_ = other.shortId_;
      spiderX_ = other.spiderX_;
      spiderY_ = other.spiderY_.Clone();
      masterKeyLog_ = other.masterKeyLog_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Config Clone() {
      return new Config(this);
    }

    /// <summary>Field number for the "show" field.</summary>
    public const int ShowFieldNumber = 1;
    private bool show_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Show {
      get { return show_; }
      set {
        show_ = value;
      }
    }

    /// <summary>Field number for the "dest" field.</summary>
    public const int DestFieldNumber = 2;
    private string dest_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Dest {
      get { return dest_; }
      set {
        dest_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private string type_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "xver" field.</summary>
    public const int XverFieldNumber = 4;
    private ulong xver_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Xver {
      get { return xver_; }
      set {
        xver_ = value;
      }
    }

    /// <summary>Field number for the "server_names" field.</summary>
    public const int ServerNamesFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_serverNames_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> serverNames_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> ServerNames {
      get { return serverNames_; }
    }

    /// <summary>Field number for the "private_key" field.</summary>
    public const int PrivateKeyFieldNumber = 6;
    private pb::ByteString privateKey_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString PrivateKey {
      get { return privateKey_; }
      set {
        privateKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "min_client_ver" field.</summary>
    public const int MinClientVerFieldNumber = 7;
    private pb::ByteString minClientVer_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString MinClientVer {
      get { return minClientVer_; }
      set {
        minClientVer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "max_client_ver" field.</summary>
    public const int MaxClientVerFieldNumber = 8;
    private pb::ByteString maxClientVer_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString MaxClientVer {
      get { return maxClientVer_; }
      set {
        maxClientVer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "max_time_diff" field.</summary>
    public const int MaxTimeDiffFieldNumber = 9;
    private ulong maxTimeDiff_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong MaxTimeDiff {
      get { return maxTimeDiff_; }
      set {
        maxTimeDiff_ = value;
      }
    }

    /// <summary>Field number for the "short_ids" field.</summary>
    public const int ShortIdsFieldNumber = 10;
    private static readonly pb::FieldCodec<pb::ByteString> _repeated_shortIds_codec
        = pb::FieldCodec.ForBytes(82);
    private readonly pbc::RepeatedField<pb::ByteString> shortIds_ = new pbc::RepeatedField<pb::ByteString>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<pb::ByteString> ShortIds {
      get { return shortIds_; }
    }

    /// <summary>Field number for the "Fingerprint" field.</summary>
    public const int FingerprintFieldNumber = 21;
    private string fingerprint_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Fingerprint {
      get { return fingerprint_; }
      set {
        fingerprint_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "server_name" field.</summary>
    public const int ServerNameFieldNumber = 22;
    private string serverName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ServerName {
      get { return serverName_; }
      set {
        serverName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "public_key" field.</summary>
    public const int PublicKeyFieldNumber = 23;
    private pb::ByteString publicKey_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString PublicKey {
      get { return publicKey_; }
      set {
        publicKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "short_id" field.</summary>
    public const int ShortIdFieldNumber = 24;
    private pb::ByteString shortId_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString ShortId {
      get { return shortId_; }
      set {
        shortId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "spider_x" field.</summary>
    public const int SpiderXFieldNumber = 25;
    private string spiderX_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SpiderX {
      get { return spiderX_; }
      set {
        spiderX_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "spider_y" field.</summary>
    public const int SpiderYFieldNumber = 26;
    private static readonly pb::FieldCodec<long> _repeated_spiderY_codec
        = pb::FieldCodec.ForInt64(210);
    private readonly pbc::RepeatedField<long> spiderY_ = new pbc::RepeatedField<long>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<long> SpiderY {
      get { return spiderY_; }
    }

    /// <summary>Field number for the "master_key_log" field.</summary>
    public const int MasterKeyLogFieldNumber = 27;
    private string masterKeyLog_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MasterKeyLog {
      get { return masterKeyLog_; }
      set {
        masterKeyLog_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Config);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Config other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Show != other.Show) return false;
      if (Dest != other.Dest) return false;
      if (Type != other.Type) return false;
      if (Xver != other.Xver) return false;
      if(!serverNames_.Equals(other.serverNames_)) return false;
      if (PrivateKey != other.PrivateKey) return false;
      if (MinClientVer != other.MinClientVer) return false;
      if (MaxClientVer != other.MaxClientVer) return false;
      if (MaxTimeDiff != other.MaxTimeDiff) return false;
      if(!shortIds_.Equals(other.shortIds_)) return false;
      if (Fingerprint != other.Fingerprint) return false;
      if (ServerName != other.ServerName) return false;
      if (PublicKey != other.PublicKey) return false;
      if (ShortId != other.ShortId) return false;
      if (SpiderX != other.SpiderX) return false;
      if(!spiderY_.Equals(other.spiderY_)) return false;
      if (MasterKeyLog != other.MasterKeyLog) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Show != false) hash ^= Show.GetHashCode();
      if (Dest.Length != 0) hash ^= Dest.GetHashCode();
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      if (Xver != 0UL) hash ^= Xver.GetHashCode();
      hash ^= serverNames_.GetHashCode();
      if (PrivateKey.Length != 0) hash ^= PrivateKey.GetHashCode();
      if (MinClientVer.Length != 0) hash ^= MinClientVer.GetHashCode();
      if (MaxClientVer.Length != 0) hash ^= MaxClientVer.GetHashCode();
      if (MaxTimeDiff != 0UL) hash ^= MaxTimeDiff.GetHashCode();
      hash ^= shortIds_.GetHashCode();
      if (Fingerprint.Length != 0) hash ^= Fingerprint.GetHashCode();
      if (ServerName.Length != 0) hash ^= ServerName.GetHashCode();
      if (PublicKey.Length != 0) hash ^= PublicKey.GetHashCode();
      if (ShortId.Length != 0) hash ^= ShortId.GetHashCode();
      if (SpiderX.Length != 0) hash ^= SpiderX.GetHashCode();
      hash ^= spiderY_.GetHashCode();
      if (MasterKeyLog.Length != 0) hash ^= MasterKeyLog.GetHashCode();
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
      if (Show != false) {
        output.WriteRawTag(8);
        output.WriteBool(Show);
      }
      if (Dest.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Dest);
      }
      if (Type.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Type);
      }
      if (Xver != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(Xver);
      }
      serverNames_.WriteTo(output, _repeated_serverNames_codec);
      if (PrivateKey.Length != 0) {
        output.WriteRawTag(50);
        output.WriteBytes(PrivateKey);
      }
      if (MinClientVer.Length != 0) {
        output.WriteRawTag(58);
        output.WriteBytes(MinClientVer);
      }
      if (MaxClientVer.Length != 0) {
        output.WriteRawTag(66);
        output.WriteBytes(MaxClientVer);
      }
      if (MaxTimeDiff != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(MaxTimeDiff);
      }
      shortIds_.WriteTo(output, _repeated_shortIds_codec);
      if (Fingerprint.Length != 0) {
        output.WriteRawTag(170, 1);
        output.WriteString(Fingerprint);
      }
      if (ServerName.Length != 0) {
        output.WriteRawTag(178, 1);
        output.WriteString(ServerName);
      }
      if (PublicKey.Length != 0) {
        output.WriteRawTag(186, 1);
        output.WriteBytes(PublicKey);
      }
      if (ShortId.Length != 0) {
        output.WriteRawTag(194, 1);
        output.WriteBytes(ShortId);
      }
      if (SpiderX.Length != 0) {
        output.WriteRawTag(202, 1);
        output.WriteString(SpiderX);
      }
      spiderY_.WriteTo(output, _repeated_spiderY_codec);
      if (MasterKeyLog.Length != 0) {
        output.WriteRawTag(218, 1);
        output.WriteString(MasterKeyLog);
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
      if (Show != false) {
        output.WriteRawTag(8);
        output.WriteBool(Show);
      }
      if (Dest.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Dest);
      }
      if (Type.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Type);
      }
      if (Xver != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(Xver);
      }
      serverNames_.WriteTo(ref output, _repeated_serverNames_codec);
      if (PrivateKey.Length != 0) {
        output.WriteRawTag(50);
        output.WriteBytes(PrivateKey);
      }
      if (MinClientVer.Length != 0) {
        output.WriteRawTag(58);
        output.WriteBytes(MinClientVer);
      }
      if (MaxClientVer.Length != 0) {
        output.WriteRawTag(66);
        output.WriteBytes(MaxClientVer);
      }
      if (MaxTimeDiff != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(MaxTimeDiff);
      }
      shortIds_.WriteTo(ref output, _repeated_shortIds_codec);
      if (Fingerprint.Length != 0) {
        output.WriteRawTag(170, 1);
        output.WriteString(Fingerprint);
      }
      if (ServerName.Length != 0) {
        output.WriteRawTag(178, 1);
        output.WriteString(ServerName);
      }
      if (PublicKey.Length != 0) {
        output.WriteRawTag(186, 1);
        output.WriteBytes(PublicKey);
      }
      if (ShortId.Length != 0) {
        output.WriteRawTag(194, 1);
        output.WriteBytes(ShortId);
      }
      if (SpiderX.Length != 0) {
        output.WriteRawTag(202, 1);
        output.WriteString(SpiderX);
      }
      spiderY_.WriteTo(ref output, _repeated_spiderY_codec);
      if (MasterKeyLog.Length != 0) {
        output.WriteRawTag(218, 1);
        output.WriteString(MasterKeyLog);
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
      if (Show != false) {
        size += 1 + 1;
      }
      if (Dest.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Dest);
      }
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (Xver != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Xver);
      }
      size += serverNames_.CalculateSize(_repeated_serverNames_codec);
      if (PrivateKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(PrivateKey);
      }
      if (MinClientVer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(MinClientVer);
      }
      if (MaxClientVer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(MaxClientVer);
      }
      if (MaxTimeDiff != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(MaxTimeDiff);
      }
      size += shortIds_.CalculateSize(_repeated_shortIds_codec);
      if (Fingerprint.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Fingerprint);
      }
      if (ServerName.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ServerName);
      }
      if (PublicKey.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeBytesSize(PublicKey);
      }
      if (ShortId.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeBytesSize(ShortId);
      }
      if (SpiderX.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(SpiderX);
      }
      size += spiderY_.CalculateSize(_repeated_spiderY_codec);
      if (MasterKeyLog.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(MasterKeyLog);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Config other) {
      if (other == null) {
        return;
      }
      if (other.Show != false) {
        Show = other.Show;
      }
      if (other.Dest.Length != 0) {
        Dest = other.Dest;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      if (other.Xver != 0UL) {
        Xver = other.Xver;
      }
      serverNames_.Add(other.serverNames_);
      if (other.PrivateKey.Length != 0) {
        PrivateKey = other.PrivateKey;
      }
      if (other.MinClientVer.Length != 0) {
        MinClientVer = other.MinClientVer;
      }
      if (other.MaxClientVer.Length != 0) {
        MaxClientVer = other.MaxClientVer;
      }
      if (other.MaxTimeDiff != 0UL) {
        MaxTimeDiff = other.MaxTimeDiff;
      }
      shortIds_.Add(other.shortIds_);
      if (other.Fingerprint.Length != 0) {
        Fingerprint = other.Fingerprint;
      }
      if (other.ServerName.Length != 0) {
        ServerName = other.ServerName;
      }
      if (other.PublicKey.Length != 0) {
        PublicKey = other.PublicKey;
      }
      if (other.ShortId.Length != 0) {
        ShortId = other.ShortId;
      }
      if (other.SpiderX.Length != 0) {
        SpiderX = other.SpiderX;
      }
      spiderY_.Add(other.spiderY_);
      if (other.MasterKeyLog.Length != 0) {
        MasterKeyLog = other.MasterKeyLog;
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
          case 8: {
            Show = input.ReadBool();
            break;
          }
          case 18: {
            Dest = input.ReadString();
            break;
          }
          case 26: {
            Type = input.ReadString();
            break;
          }
          case 32: {
            Xver = input.ReadUInt64();
            break;
          }
          case 42: {
            serverNames_.AddEntriesFrom(input, _repeated_serverNames_codec);
            break;
          }
          case 50: {
            PrivateKey = input.ReadBytes();
            break;
          }
          case 58: {
            MinClientVer = input.ReadBytes();
            break;
          }
          case 66: {
            MaxClientVer = input.ReadBytes();
            break;
          }
          case 72: {
            MaxTimeDiff = input.ReadUInt64();
            break;
          }
          case 82: {
            shortIds_.AddEntriesFrom(input, _repeated_shortIds_codec);
            break;
          }
          case 170: {
            Fingerprint = input.ReadString();
            break;
          }
          case 178: {
            ServerName = input.ReadString();
            break;
          }
          case 186: {
            PublicKey = input.ReadBytes();
            break;
          }
          case 194: {
            ShortId = input.ReadBytes();
            break;
          }
          case 202: {
            SpiderX = input.ReadString();
            break;
          }
          case 210:
          case 208: {
            spiderY_.AddEntriesFrom(input, _repeated_spiderY_codec);
            break;
          }
          case 218: {
            MasterKeyLog = input.ReadString();
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
          case 8: {
            Show = input.ReadBool();
            break;
          }
          case 18: {
            Dest = input.ReadString();
            break;
          }
          case 26: {
            Type = input.ReadString();
            break;
          }
          case 32: {
            Xver = input.ReadUInt64();
            break;
          }
          case 42: {
            serverNames_.AddEntriesFrom(ref input, _repeated_serverNames_codec);
            break;
          }
          case 50: {
            PrivateKey = input.ReadBytes();
            break;
          }
          case 58: {
            MinClientVer = input.ReadBytes();
            break;
          }
          case 66: {
            MaxClientVer = input.ReadBytes();
            break;
          }
          case 72: {
            MaxTimeDiff = input.ReadUInt64();
            break;
          }
          case 82: {
            shortIds_.AddEntriesFrom(ref input, _repeated_shortIds_codec);
            break;
          }
          case 170: {
            Fingerprint = input.ReadString();
            break;
          }
          case 178: {
            ServerName = input.ReadString();
            break;
          }
          case 186: {
            PublicKey = input.ReadBytes();
            break;
          }
          case 194: {
            ShortId = input.ReadBytes();
            break;
          }
          case 202: {
            SpiderX = input.ReadString();
            break;
          }
          case 210:
          case 208: {
            spiderY_.AddEntriesFrom(ref input, _repeated_spiderY_codec);
            break;
          }
          case 218: {
            MasterKeyLog = input.ReadString();
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
