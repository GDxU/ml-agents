// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: communicator_objects/resolution_proto.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MLAgents.CommunicatorObjects {

  /// <summary>Holder for reflection information generated from communicator_objects/resolution_proto.proto</summary>
  public static partial class ResolutionProtoReflection {

    #region Descriptor
    /// <summary>File descriptor for communicator_objects/resolution_proto.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResolutionProtoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Citjb21tdW5pY2F0b3Jfb2JqZWN0cy9yZXNvbHV0aW9uX3Byb3RvLnByb3Rv",
            "EhRjb21tdW5pY2F0b3Jfb2JqZWN0cyJECg9SZXNvbHV0aW9uUHJvdG8SDQoF",
            "d2lkdGgYASABKAUSDgoGaGVpZ2h0GAIgASgFEhIKCmdyYXlfc2NhbGUYAyAB",
            "KAhCH6oCHE1MQWdlbnRzLkNvbW11bmljYXRvck9iamVjdHNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MLAgents.CommunicatorObjects.ResolutionProto), global::MLAgents.CommunicatorObjects.ResolutionProto.Parser, new[]{ "Width", "Height", "GrayScale" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ResolutionProto : pb::IMessage<ResolutionProto> {
    private static readonly pb::MessageParser<ResolutionProto> _parser = new pb::MessageParser<ResolutionProto>(() => new ResolutionProto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResolutionProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MLAgents.CommunicatorObjects.ResolutionProtoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResolutionProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResolutionProto(ResolutionProto other) : this() {
      width_ = other.width_;
      height_ = other.height_;
      grayScale_ = other.grayScale_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResolutionProto Clone() {
      return new ResolutionProto(this);
    }

    /// <summary>Field number for the "width" field.</summary>
    public const int WidthFieldNumber = 1;
    private int width_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Width {
      get { return width_; }
      set {
        width_ = value;
      }
    }

    /// <summary>Field number for the "height" field.</summary>
    public const int HeightFieldNumber = 2;
    private int height_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Height {
      get { return height_; }
      set {
        height_ = value;
      }
    }

    /// <summary>Field number for the "gray_scale" field.</summary>
    public const int GrayScaleFieldNumber = 3;
    private bool grayScale_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool GrayScale {
      get { return grayScale_; }
      set {
        grayScale_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResolutionProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ResolutionProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Width != other.Width) return false;
      if (Height != other.Height) return false;
      if (GrayScale != other.GrayScale) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Width != 0) hash ^= Width.GetHashCode();
      if (Height != 0) hash ^= Height.GetHashCode();
      if (GrayScale != false) hash ^= GrayScale.GetHashCode();
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
      if (Width != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Width);
      }
      if (Height != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Height);
      }
      if (GrayScale != false) {
        output.WriteRawTag(24);
        output.WriteBool(GrayScale);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Width != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Width);
      }
      if (Height != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Height);
      }
      if (GrayScale != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ResolutionProto other) {
      if (other == null) {
        return;
      }
      if (other.Width != 0) {
        Width = other.Width;
      }
      if (other.Height != 0) {
        Height = other.Height;
      }
      if (other.GrayScale != false) {
        GrayScale = other.GrayScale;
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
            Width = input.ReadInt32();
            break;
          }
          case 16: {
            Height = input.ReadInt32();
            break;
          }
          case 24: {
            GrayScale = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
