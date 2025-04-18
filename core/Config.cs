// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: core/config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Xray.Core {

  /// <summary>Holder for reflection information generated from core/config.proto</summary>
  public static partial class ConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for core/config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFjb3JlL2NvbmZpZy5wcm90bxIJeHJheS5jb3JlGiFjb21tb24vc2VyaWFs",
            "L3R5cGVkX21lc3NhZ2UucHJvdG8i2AEKBkNvbmZpZxIwCgdpbmJvdW5kGAEg",
            "AygLMh8ueHJheS5jb3JlLkluYm91bmRIYW5kbGVyQ29uZmlnEjIKCG91dGJv",
            "dW5kGAIgAygLMiAueHJheS5jb3JlLk91dGJvdW5kSGFuZGxlckNvbmZpZxIt",
            "CgNhcHAYBCADKAsyIC54cmF5LmNvbW1vbi5zZXJpYWwuVHlwZWRNZXNzYWdl",
            "EjMKCWV4dGVuc2lvbhgGIAMoCzIgLnhyYXkuY29tbW9uLnNlcmlhbC5UeXBl",
            "ZE1lc3NhZ2VKBAgDEAQimgEKFEluYm91bmRIYW5kbGVyQ29uZmlnEgsKA3Rh",
            "ZxgBIAEoCRI7ChFyZWNlaXZlcl9zZXR0aW5ncxgCIAEoCzIgLnhyYXkuY29t",
            "bW9uLnNlcmlhbC5UeXBlZE1lc3NhZ2USOAoOcHJveHlfc2V0dGluZ3MYAyAB",
            "KAsyIC54cmF5LmNvbW1vbi5zZXJpYWwuVHlwZWRNZXNzYWdlIroBChVPdXRi",
            "b3VuZEhhbmRsZXJDb25maWcSCwoDdGFnGAEgASgJEjkKD3NlbmRlcl9zZXR0",
            "aW5ncxgCIAEoCzIgLnhyYXkuY29tbW9uLnNlcmlhbC5UeXBlZE1lc3NhZ2US",
            "OAoOcHJveHlfc2V0dGluZ3MYAyABKAsyIC54cmF5LmNvbW1vbi5zZXJpYWwu",
            "VHlwZWRNZXNzYWdlEg4KBmV4cGlyZRgEIAEoAxIPCgdjb21tZW50GAUgASgJ",
            "Qj0KDWNvbS54cmF5LmNvcmVQAVoeZ2l0aHViLmNvbS94dGxzL3hyYXktY29y",
            "ZS9jb3JlqgIJWHJheS5Db3JlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Xray.Common.Serial.TypedMessageReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Xray.Core.Config), global::Xray.Core.Config.Parser, new[]{ "Inbound", "Outbound", "App", "Extension" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Xray.Core.InboundHandlerConfig), global::Xray.Core.InboundHandlerConfig.Parser, new[]{ "Tag", "ReceiverSettings", "ProxySettings" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Xray.Core.OutboundHandlerConfig), global::Xray.Core.OutboundHandlerConfig.Parser, new[]{ "Tag", "SenderSettings", "ProxySettings", "Expire", "Comment" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Config is the master config of Xray. Xray takes this config as input and
  /// functions accordingly.
  /// </summary>
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
      get { return global::Xray.Core.ConfigReflection.Descriptor.MessageTypes[0]; }
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
      inbound_ = other.inbound_.Clone();
      outbound_ = other.outbound_.Clone();
      app_ = other.app_.Clone();
      extension_ = other.extension_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Config Clone() {
      return new Config(this);
    }

    /// <summary>Field number for the "inbound" field.</summary>
    public const int InboundFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Xray.Core.InboundHandlerConfig> _repeated_inbound_codec
        = pb::FieldCodec.ForMessage(10, global::Xray.Core.InboundHandlerConfig.Parser);
    private readonly pbc::RepeatedField<global::Xray.Core.InboundHandlerConfig> inbound_ = new pbc::RepeatedField<global::Xray.Core.InboundHandlerConfig>();
    /// <summary>
    /// Inbound handler configurations. Must have at least one item.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Xray.Core.InboundHandlerConfig> Inbound {
      get { return inbound_; }
    }

    /// <summary>Field number for the "outbound" field.</summary>
    public const int OutboundFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Xray.Core.OutboundHandlerConfig> _repeated_outbound_codec
        = pb::FieldCodec.ForMessage(18, global::Xray.Core.OutboundHandlerConfig.Parser);
    private readonly pbc::RepeatedField<global::Xray.Core.OutboundHandlerConfig> outbound_ = new pbc::RepeatedField<global::Xray.Core.OutboundHandlerConfig>();
    /// <summary>
    /// Outbound handler configurations. Must have at least one item. The first
    /// item is used as default for routing.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Xray.Core.OutboundHandlerConfig> Outbound {
      get { return outbound_; }
    }

    /// <summary>Field number for the "app" field.</summary>
    public const int AppFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Xray.Common.Serial.TypedMessage> _repeated_app_codec
        = pb::FieldCodec.ForMessage(34, global::Xray.Common.Serial.TypedMessage.Parser);
    private readonly pbc::RepeatedField<global::Xray.Common.Serial.TypedMessage> app_ = new pbc::RepeatedField<global::Xray.Common.Serial.TypedMessage>();
    /// <summary>
    /// App is for configurations of all features in Xray. A feature must
    /// implement the Feature interface, and its config type must be registered
    /// through common.RegisterConfig.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Xray.Common.Serial.TypedMessage> App {
      get { return app_; }
    }

    /// <summary>Field number for the "extension" field.</summary>
    public const int ExtensionFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Xray.Common.Serial.TypedMessage> _repeated_extension_codec
        = pb::FieldCodec.ForMessage(50, global::Xray.Common.Serial.TypedMessage.Parser);
    private readonly pbc::RepeatedField<global::Xray.Common.Serial.TypedMessage> extension_ = new pbc::RepeatedField<global::Xray.Common.Serial.TypedMessage>();
    /// <summary>
    /// Configuration for extensions. The config may not work if corresponding
    /// extension is not loaded into Xray. Xray will ignore such config during
    /// initialization.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Xray.Common.Serial.TypedMessage> Extension {
      get { return extension_; }
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
      if(!inbound_.Equals(other.inbound_)) return false;
      if(!outbound_.Equals(other.outbound_)) return false;
      if(!app_.Equals(other.app_)) return false;
      if(!extension_.Equals(other.extension_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= inbound_.GetHashCode();
      hash ^= outbound_.GetHashCode();
      hash ^= app_.GetHashCode();
      hash ^= extension_.GetHashCode();
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
      inbound_.WriteTo(output, _repeated_inbound_codec);
      outbound_.WriteTo(output, _repeated_outbound_codec);
      app_.WriteTo(output, _repeated_app_codec);
      extension_.WriteTo(output, _repeated_extension_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      inbound_.WriteTo(ref output, _repeated_inbound_codec);
      outbound_.WriteTo(ref output, _repeated_outbound_codec);
      app_.WriteTo(ref output, _repeated_app_codec);
      extension_.WriteTo(ref output, _repeated_extension_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += inbound_.CalculateSize(_repeated_inbound_codec);
      size += outbound_.CalculateSize(_repeated_outbound_codec);
      size += app_.CalculateSize(_repeated_app_codec);
      size += extension_.CalculateSize(_repeated_extension_codec);
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
      inbound_.Add(other.inbound_);
      outbound_.Add(other.outbound_);
      app_.Add(other.app_);
      extension_.Add(other.extension_);
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
            inbound_.AddEntriesFrom(input, _repeated_inbound_codec);
            break;
          }
          case 18: {
            outbound_.AddEntriesFrom(input, _repeated_outbound_codec);
            break;
          }
          case 34: {
            app_.AddEntriesFrom(input, _repeated_app_codec);
            break;
          }
          case 50: {
            extension_.AddEntriesFrom(input, _repeated_extension_codec);
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
            inbound_.AddEntriesFrom(ref input, _repeated_inbound_codec);
            break;
          }
          case 18: {
            outbound_.AddEntriesFrom(ref input, _repeated_outbound_codec);
            break;
          }
          case 34: {
            app_.AddEntriesFrom(ref input, _repeated_app_codec);
            break;
          }
          case 50: {
            extension_.AddEntriesFrom(ref input, _repeated_extension_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// InboundHandlerConfig is the configuration for inbound handler.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class InboundHandlerConfig : pb::IMessage<InboundHandlerConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<InboundHandlerConfig> _parser = new pb::MessageParser<InboundHandlerConfig>(() => new InboundHandlerConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<InboundHandlerConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Xray.Core.ConfigReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InboundHandlerConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InboundHandlerConfig(InboundHandlerConfig other) : this() {
      tag_ = other.tag_;
      receiverSettings_ = other.receiverSettings_ != null ? other.receiverSettings_.Clone() : null;
      proxySettings_ = other.proxySettings_ != null ? other.proxySettings_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InboundHandlerConfig Clone() {
      return new InboundHandlerConfig(this);
    }

    /// <summary>Field number for the "tag" field.</summary>
    public const int TagFieldNumber = 1;
    private string tag_ = "";
    /// <summary>
    /// Tag of the inbound handler. The tag must be unique among all inbound
    /// handlers
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Tag {
      get { return tag_; }
      set {
        tag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "receiver_settings" field.</summary>
    public const int ReceiverSettingsFieldNumber = 2;
    private global::Xray.Common.Serial.TypedMessage receiverSettings_;
    /// <summary>
    /// Settings for how this inbound proxy is handled.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Xray.Common.Serial.TypedMessage ReceiverSettings {
      get { return receiverSettings_; }
      set {
        receiverSettings_ = value;
      }
    }

    /// <summary>Field number for the "proxy_settings" field.</summary>
    public const int ProxySettingsFieldNumber = 3;
    private global::Xray.Common.Serial.TypedMessage proxySettings_;
    /// <summary>
    /// Settings for inbound proxy. Must be one of the inbound proxies.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Xray.Common.Serial.TypedMessage ProxySettings {
      get { return proxySettings_; }
      set {
        proxySettings_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as InboundHandlerConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(InboundHandlerConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Tag != other.Tag) return false;
      if (!object.Equals(ReceiverSettings, other.ReceiverSettings)) return false;
      if (!object.Equals(ProxySettings, other.ProxySettings)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Tag.Length != 0) hash ^= Tag.GetHashCode();
      if (receiverSettings_ != null) hash ^= ReceiverSettings.GetHashCode();
      if (proxySettings_ != null) hash ^= ProxySettings.GetHashCode();
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
      if (Tag.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Tag);
      }
      if (receiverSettings_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ReceiverSettings);
      }
      if (proxySettings_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ProxySettings);
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
      if (Tag.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Tag);
      }
      if (receiverSettings_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ReceiverSettings);
      }
      if (proxySettings_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ProxySettings);
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
      if (Tag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Tag);
      }
      if (receiverSettings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReceiverSettings);
      }
      if (proxySettings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProxySettings);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(InboundHandlerConfig other) {
      if (other == null) {
        return;
      }
      if (other.Tag.Length != 0) {
        Tag = other.Tag;
      }
      if (other.receiverSettings_ != null) {
        if (receiverSettings_ == null) {
          ReceiverSettings = new global::Xray.Common.Serial.TypedMessage();
        }
        ReceiverSettings.MergeFrom(other.ReceiverSettings);
      }
      if (other.proxySettings_ != null) {
        if (proxySettings_ == null) {
          ProxySettings = new global::Xray.Common.Serial.TypedMessage();
        }
        ProxySettings.MergeFrom(other.ProxySettings);
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
            Tag = input.ReadString();
            break;
          }
          case 18: {
            if (receiverSettings_ == null) {
              ReceiverSettings = new global::Xray.Common.Serial.TypedMessage();
            }
            input.ReadMessage(ReceiverSettings);
            break;
          }
          case 26: {
            if (proxySettings_ == null) {
              ProxySettings = new global::Xray.Common.Serial.TypedMessage();
            }
            input.ReadMessage(ProxySettings);
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
            Tag = input.ReadString();
            break;
          }
          case 18: {
            if (receiverSettings_ == null) {
              ReceiverSettings = new global::Xray.Common.Serial.TypedMessage();
            }
            input.ReadMessage(ReceiverSettings);
            break;
          }
          case 26: {
            if (proxySettings_ == null) {
              ProxySettings = new global::Xray.Common.Serial.TypedMessage();
            }
            input.ReadMessage(ProxySettings);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// OutboundHandlerConfig is the configuration for outbound handler.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class OutboundHandlerConfig : pb::IMessage<OutboundHandlerConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OutboundHandlerConfig> _parser = new pb::MessageParser<OutboundHandlerConfig>(() => new OutboundHandlerConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OutboundHandlerConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Xray.Core.ConfigReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OutboundHandlerConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OutboundHandlerConfig(OutboundHandlerConfig other) : this() {
      tag_ = other.tag_;
      senderSettings_ = other.senderSettings_ != null ? other.senderSettings_.Clone() : null;
      proxySettings_ = other.proxySettings_ != null ? other.proxySettings_.Clone() : null;
      expire_ = other.expire_;
      comment_ = other.comment_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OutboundHandlerConfig Clone() {
      return new OutboundHandlerConfig(this);
    }

    /// <summary>Field number for the "tag" field.</summary>
    public const int TagFieldNumber = 1;
    private string tag_ = "";
    /// <summary>
    /// Tag of this outbound handler.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Tag {
      get { return tag_; }
      set {
        tag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sender_settings" field.</summary>
    public const int SenderSettingsFieldNumber = 2;
    private global::Xray.Common.Serial.TypedMessage senderSettings_;
    /// <summary>
    /// Settings for how to dial connection for this outbound handler.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Xray.Common.Serial.TypedMessage SenderSettings {
      get { return senderSettings_; }
      set {
        senderSettings_ = value;
      }
    }

    /// <summary>Field number for the "proxy_settings" field.</summary>
    public const int ProxySettingsFieldNumber = 3;
    private global::Xray.Common.Serial.TypedMessage proxySettings_;
    /// <summary>
    /// Settings for this outbound proxy. Must be one of the outbound proxies.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Xray.Common.Serial.TypedMessage ProxySettings {
      get { return proxySettings_; }
      set {
        proxySettings_ = value;
      }
    }

    /// <summary>Field number for the "expire" field.</summary>
    public const int ExpireFieldNumber = 4;
    private long expire_;
    /// <summary>
    /// If not zero, this outbound will be expired in seconds. Not used for now.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Expire {
      get { return expire_; }
      set {
        expire_ = value;
      }
    }

    /// <summary>Field number for the "comment" field.</summary>
    public const int CommentFieldNumber = 5;
    private string comment_ = "";
    /// <summary>
    /// Comment of this outbound handler. Not used for now.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Comment {
      get { return comment_; }
      set {
        comment_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OutboundHandlerConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OutboundHandlerConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Tag != other.Tag) return false;
      if (!object.Equals(SenderSettings, other.SenderSettings)) return false;
      if (!object.Equals(ProxySettings, other.ProxySettings)) return false;
      if (Expire != other.Expire) return false;
      if (Comment != other.Comment) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Tag.Length != 0) hash ^= Tag.GetHashCode();
      if (senderSettings_ != null) hash ^= SenderSettings.GetHashCode();
      if (proxySettings_ != null) hash ^= ProxySettings.GetHashCode();
      if (Expire != 0L) hash ^= Expire.GetHashCode();
      if (Comment.Length != 0) hash ^= Comment.GetHashCode();
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
      if (Tag.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Tag);
      }
      if (senderSettings_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(SenderSettings);
      }
      if (proxySettings_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ProxySettings);
      }
      if (Expire != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(Expire);
      }
      if (Comment.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Comment);
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
      if (Tag.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Tag);
      }
      if (senderSettings_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(SenderSettings);
      }
      if (proxySettings_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ProxySettings);
      }
      if (Expire != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(Expire);
      }
      if (Comment.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Comment);
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
      if (Tag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Tag);
      }
      if (senderSettings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SenderSettings);
      }
      if (proxySettings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProxySettings);
      }
      if (Expire != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Expire);
      }
      if (Comment.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Comment);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OutboundHandlerConfig other) {
      if (other == null) {
        return;
      }
      if (other.Tag.Length != 0) {
        Tag = other.Tag;
      }
      if (other.senderSettings_ != null) {
        if (senderSettings_ == null) {
          SenderSettings = new global::Xray.Common.Serial.TypedMessage();
        }
        SenderSettings.MergeFrom(other.SenderSettings);
      }
      if (other.proxySettings_ != null) {
        if (proxySettings_ == null) {
          ProxySettings = new global::Xray.Common.Serial.TypedMessage();
        }
        ProxySettings.MergeFrom(other.ProxySettings);
      }
      if (other.Expire != 0L) {
        Expire = other.Expire;
      }
      if (other.Comment.Length != 0) {
        Comment = other.Comment;
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
            Tag = input.ReadString();
            break;
          }
          case 18: {
            if (senderSettings_ == null) {
              SenderSettings = new global::Xray.Common.Serial.TypedMessage();
            }
            input.ReadMessage(SenderSettings);
            break;
          }
          case 26: {
            if (proxySettings_ == null) {
              ProxySettings = new global::Xray.Common.Serial.TypedMessage();
            }
            input.ReadMessage(ProxySettings);
            break;
          }
          case 32: {
            Expire = input.ReadInt64();
            break;
          }
          case 42: {
            Comment = input.ReadString();
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
            Tag = input.ReadString();
            break;
          }
          case 18: {
            if (senderSettings_ == null) {
              SenderSettings = new global::Xray.Common.Serial.TypedMessage();
            }
            input.ReadMessage(SenderSettings);
            break;
          }
          case 26: {
            if (proxySettings_ == null) {
              ProxySettings = new global::Xray.Common.Serial.TypedMessage();
            }
            input.ReadMessage(ProxySettings);
            break;
          }
          case 32: {
            Expire = input.ReadInt64();
            break;
          }
          case 42: {
            Comment = input.ReadString();
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
