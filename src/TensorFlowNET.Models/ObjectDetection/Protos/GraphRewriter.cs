// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: object_detection/protos/graph_rewriter.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow.Models.ObjectDetection.Protos {

  /// <summary>Holder for reflection information generated from object_detection/protos/graph_rewriter.proto</summary>
  public static partial class GraphRewriterReflection {

    #region Descriptor
    /// <summary>File descriptor for object_detection/protos/graph_rewriter.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GraphRewriterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixvYmplY3RfZGV0ZWN0aW9uL3Byb3Rvcy9ncmFwaF9yZXdyaXRlci5wcm90",
            "bxIXb2JqZWN0X2RldGVjdGlvbi5wcm90b3MiTAoNR3JhcGhSZXdyaXRlchI7",
            "CgxxdWFudGl6YXRpb24YASABKAsyJS5vYmplY3RfZGV0ZWN0aW9uLnByb3Rv",
            "cy5RdWFudGl6YXRpb24iXgoMUXVhbnRpemF0aW9uEg0KBWRlbGF5GAEgASgF",
            "EhMKC3dlaWdodF9iaXRzGAIgASgFEhcKD2FjdGl2YXRpb25fYml0cxgDIAEo",
            "BRIRCglzeW1tZXRyaWMYBCABKAhiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Models.ObjectDetection.Protos.GraphRewriter), global::Tensorflow.Models.ObjectDetection.Protos.GraphRewriter.Parser, new[]{ "Quantization" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Models.ObjectDetection.Protos.Quantization), global::Tensorflow.Models.ObjectDetection.Protos.Quantization.Parser, new[]{ "Delay", "WeightBits", "ActivationBits", "Symmetric" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Message to configure graph rewriter for the tf graph.
  /// </summary>
  public sealed partial class GraphRewriter : pb::IMessage<GraphRewriter> {
    private static readonly pb::MessageParser<GraphRewriter> _parser = new pb::MessageParser<GraphRewriter>(() => new GraphRewriter());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GraphRewriter> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Models.ObjectDetection.Protos.GraphRewriterReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GraphRewriter() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GraphRewriter(GraphRewriter other) : this() {
      quantization_ = other.quantization_ != null ? other.quantization_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GraphRewriter Clone() {
      return new GraphRewriter(this);
    }

    /// <summary>Field number for the "quantization" field.</summary>
    public const int QuantizationFieldNumber = 1;
    private global::Tensorflow.Models.ObjectDetection.Protos.Quantization quantization_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.Models.ObjectDetection.Protos.Quantization Quantization {
      get { return quantization_; }
      set {
        quantization_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GraphRewriter);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GraphRewriter other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Quantization, other.Quantization)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (quantization_ != null) hash ^= Quantization.GetHashCode();
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
      if (quantization_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Quantization);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (quantization_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Quantization);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GraphRewriter other) {
      if (other == null) {
        return;
      }
      if (other.quantization_ != null) {
        if (quantization_ == null) {
          quantization_ = new global::Tensorflow.Models.ObjectDetection.Protos.Quantization();
        }
        Quantization.MergeFrom(other.Quantization);
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
            if (quantization_ == null) {
              quantization_ = new global::Tensorflow.Models.ObjectDetection.Protos.Quantization();
            }
            input.ReadMessage(quantization_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Message for quantization options. See
  /// tensorflow/contrib/quantize/python/quantize.py for details.
  /// </summary>
  public sealed partial class Quantization : pb::IMessage<Quantization> {
    private static readonly pb::MessageParser<Quantization> _parser = new pb::MessageParser<Quantization>(() => new Quantization());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Quantization> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Models.ObjectDetection.Protos.GraphRewriterReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Quantization() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Quantization(Quantization other) : this() {
      delay_ = other.delay_;
      weightBits_ = other.weightBits_;
      activationBits_ = other.activationBits_;
      symmetric_ = other.symmetric_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Quantization Clone() {
      return new Quantization(this);
    }

    /// <summary>Field number for the "delay" field.</summary>
    public const int DelayFieldNumber = 1;
    private int delay_;
    /// <summary>
    /// Number of steps to delay before quantization takes effect during training.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Delay {
      get { return delay_; }
      set {
        delay_ = value;
      }
    }

    /// <summary>Field number for the "weight_bits" field.</summary>
    public const int WeightBitsFieldNumber = 2;
    private int weightBits_;
    /// <summary>
    /// Number of bits to use for quantizing weights.
    /// Only 8 bit is supported for now.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int WeightBits {
      get { return weightBits_; }
      set {
        weightBits_ = value;
      }
    }

    /// <summary>Field number for the "activation_bits" field.</summary>
    public const int ActivationBitsFieldNumber = 3;
    private int activationBits_;
    /// <summary>
    /// Number of bits to use for quantizing activations.
    /// Only 8 bit is supported for now.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ActivationBits {
      get { return activationBits_; }
      set {
        activationBits_ = value;
      }
    }

    /// <summary>Field number for the "symmetric" field.</summary>
    public const int SymmetricFieldNumber = 4;
    private bool symmetric_;
    /// <summary>
    /// Whether to use symmetric weight quantization.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Symmetric {
      get { return symmetric_; }
      set {
        symmetric_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Quantization);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Quantization other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Delay != other.Delay) return false;
      if (WeightBits != other.WeightBits) return false;
      if (ActivationBits != other.ActivationBits) return false;
      if (Symmetric != other.Symmetric) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Delay != 0) hash ^= Delay.GetHashCode();
      if (WeightBits != 0) hash ^= WeightBits.GetHashCode();
      if (ActivationBits != 0) hash ^= ActivationBits.GetHashCode();
      if (Symmetric != false) hash ^= Symmetric.GetHashCode();
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
      if (Delay != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Delay);
      }
      if (WeightBits != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(WeightBits);
      }
      if (ActivationBits != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(ActivationBits);
      }
      if (Symmetric != false) {
        output.WriteRawTag(32);
        output.WriteBool(Symmetric);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Delay != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Delay);
      }
      if (WeightBits != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(WeightBits);
      }
      if (ActivationBits != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ActivationBits);
      }
      if (Symmetric != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Quantization other) {
      if (other == null) {
        return;
      }
      if (other.Delay != 0) {
        Delay = other.Delay;
      }
      if (other.WeightBits != 0) {
        WeightBits = other.WeightBits;
      }
      if (other.ActivationBits != 0) {
        ActivationBits = other.ActivationBits;
      }
      if (other.Symmetric != false) {
        Symmetric = other.Symmetric;
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
            Delay = input.ReadInt32();
            break;
          }
          case 16: {
            WeightBits = input.ReadInt32();
            break;
          }
          case 24: {
            ActivationBits = input.ReadInt32();
            break;
          }
          case 32: {
            Symmetric = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
