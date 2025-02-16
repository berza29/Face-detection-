// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/fileTransport.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace grpcFileTransportServer {

  /// <summary>Holder for reflection information generated from Protos/fileTransport.proto</summary>
  public static partial class FileTransportReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/fileTransport.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FileTransportReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpQcm90b3MvZmlsZVRyYW5zcG9ydC5wcm90bxIFZ3JlZXQaG2dvb2dsZS9w",
            "cm90b2J1Zi9lbXB0eS5wcm90byIwCgVGSW5mbxIQCghmaWxlTmFtZRgBIAEo",
            "CRIVCg1maWxlRXh0ZW5zaW9uGAIgASgJIl8KC0J5dGVDb250ZW50EhAKCGZp",
            "bGVTaXplGAEgASgDEg4KBmJ1ZmZlchgCIAEoDBISCgpyZWFkZWRCeXRlGAMg",
            "ASgREhoKBGluZm8YBCABKAsyDC5ncmVldC5GSW5mbzJJCgtGaWxlU2Vydmlj",
            "ZRI6CgpGaWxlVXBsb2FkEhIuZ3JlZXQuQnl0ZUNvbnRlbnQaFi5nb29nbGUu",
            "cHJvdG9idWYuRW1wdHkoAUIaqgIXZ3JwY0ZpbGVUcmFuc3BvcnRTZXJ2ZXJi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::grpcFileTransportServer.FInfo), global::grpcFileTransportServer.FInfo.Parser, new[]{ "FileName", "FileExtension" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::grpcFileTransportServer.ByteContent), global::grpcFileTransportServer.ByteContent.Parser, new[]{ "FileSize", "Buffer", "ReadedByte", "Info" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FInfo : pb::IMessage<FInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FInfo> _parser = new pb::MessageParser<FInfo>(() => new FInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::grpcFileTransportServer.FileTransportReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FInfo(FInfo other) : this() {
      fileName_ = other.fileName_;
      fileExtension_ = other.fileExtension_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FInfo Clone() {
      return new FInfo(this);
    }

    /// <summary>Field number for the "fileName" field.</summary>
    public const int FileNameFieldNumber = 1;
    private string fileName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string FileName {
      get { return fileName_; }
      set {
        fileName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fileExtension" field.</summary>
    public const int FileExtensionFieldNumber = 2;
    private string fileExtension_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string FileExtension {
      get { return fileExtension_; }
      set {
        fileExtension_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FileName != other.FileName) return false;
      if (FileExtension != other.FileExtension) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FileName.Length != 0) hash ^= FileName.GetHashCode();
      if (FileExtension.Length != 0) hash ^= FileExtension.GetHashCode();
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
      if (FileName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FileName);
      }
      if (FileExtension.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FileExtension);
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
      if (FileName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FileName);
      }
      if (FileExtension.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FileExtension);
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
      if (FileName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FileName);
      }
      if (FileExtension.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FileExtension);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FInfo other) {
      if (other == null) {
        return;
      }
      if (other.FileName.Length != 0) {
        FileName = other.FileName;
      }
      if (other.FileExtension.Length != 0) {
        FileExtension = other.FileExtension;
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
          case 10: {
            FileName = input.ReadString();
            break;
          }
          case 18: {
            FileExtension = input.ReadString();
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
            FileName = input.ReadString();
            break;
          }
          case 18: {
            FileExtension = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ByteContent : pb::IMessage<ByteContent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ByteContent> _parser = new pb::MessageParser<ByteContent>(() => new ByteContent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ByteContent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::grpcFileTransportServer.FileTransportReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ByteContent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ByteContent(ByteContent other) : this() {
      fileSize_ = other.fileSize_;
      buffer_ = other.buffer_;
      readedByte_ = other.readedByte_;
      info_ = other.info_ != null ? other.info_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ByteContent Clone() {
      return new ByteContent(this);
    }

    /// <summary>Field number for the "fileSize" field.</summary>
    public const int FileSizeFieldNumber = 1;
    private long fileSize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long FileSize {
      get { return fileSize_; }
      set {
        fileSize_ = value;
      }
    }

    /// <summary>Field number for the "buffer" field.</summary>
    public const int BufferFieldNumber = 2;
    private pb::ByteString buffer_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Buffer {
      get { return buffer_; }
      set {
        buffer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "readedByte" field.</summary>
    public const int ReadedByteFieldNumber = 3;
    private int readedByte_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ReadedByte {
      get { return readedByte_; }
      set {
        readedByte_ = value;
      }
    }

    /// <summary>Field number for the "info" field.</summary>
    public const int InfoFieldNumber = 4;
    private global::grpcFileTransportServer.FInfo info_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::grpcFileTransportServer.FInfo Info {
      get { return info_; }
      set {
        info_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ByteContent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ByteContent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FileSize != other.FileSize) return false;
      if (Buffer != other.Buffer) return false;
      if (ReadedByte != other.ReadedByte) return false;
      if (!object.Equals(Info, other.Info)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FileSize != 0L) hash ^= FileSize.GetHashCode();
      if (Buffer.Length != 0) hash ^= Buffer.GetHashCode();
      if (ReadedByte != 0) hash ^= ReadedByte.GetHashCode();
      if (info_ != null) hash ^= Info.GetHashCode();
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
      if (FileSize != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(FileSize);
      }
      if (Buffer.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Buffer);
      }
      if (ReadedByte != 0) {
        output.WriteRawTag(24);
        output.WriteSInt32(ReadedByte);
      }
      if (info_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Info);
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
      if (FileSize != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(FileSize);
      }
      if (Buffer.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Buffer);
      }
      if (ReadedByte != 0) {
        output.WriteRawTag(24);
        output.WriteSInt32(ReadedByte);
      }
      if (info_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Info);
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
      if (FileSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(FileSize);
      }
      if (Buffer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Buffer);
      }
      if (ReadedByte != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(ReadedByte);
      }
      if (info_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Info);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ByteContent other) {
      if (other == null) {
        return;
      }
      if (other.FileSize != 0L) {
        FileSize = other.FileSize;
      }
      if (other.Buffer.Length != 0) {
        Buffer = other.Buffer;
      }
      if (other.ReadedByte != 0) {
        ReadedByte = other.ReadedByte;
      }
      if (other.info_ != null) {
        if (info_ == null) {
          Info = new global::grpcFileTransportServer.FInfo();
        }
        Info.MergeFrom(other.Info);
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
            FileSize = input.ReadInt64();
            break;
          }
          case 18: {
            Buffer = input.ReadBytes();
            break;
          }
          case 24: {
            ReadedByte = input.ReadSInt32();
            break;
          }
          case 34: {
            if (info_ == null) {
              Info = new global::grpcFileTransportServer.FInfo();
            }
            input.ReadMessage(Info);
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
            FileSize = input.ReadInt64();
            break;
          }
          case 18: {
            Buffer = input.ReadBytes();
            break;
          }
          case 24: {
            ReadedByte = input.ReadSInt32();
            break;
          }
          case 34: {
            if (info_ == null) {
              Info = new global::grpcFileTransportServer.FInfo();
            }
            input.ReadMessage(Info);
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
