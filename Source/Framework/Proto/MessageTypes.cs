// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: bgs/low/pb/client/message_types.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bgs.Protocol {

  /// <summary>Holder for reflection information generated from bgs/low/pb/client/message_types.proto</summary>
  public static partial class MessageTypesReflection {

    #region Descriptor
    /// <summary>File descriptor for bgs/low/pb/client/message_types.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageTypesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiViZ3MvbG93L3BiL2NsaWVudC9tZXNzYWdlX3R5cGVzLnByb3RvEgxiZ3Mu",
            "cHJvdG9jb2wiLAoJTWVzc2FnZUlkEg0KBWVwb2NoGAEgASgEEhAKCHBvc2l0",
            "aW9uGAIgASgEKjQKD1R5cGluZ0luZGljYXRvchIQCgxUWVBJTkdfU1RBUlQQ",
            "ABIPCgtUWVBJTkdfU1RPUBAB"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Bgs.Protocol.TypingIndicator), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.MessageId), global::Bgs.Protocol.MessageId.Parser, new[]{ "Epoch", "Position" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum TypingIndicator {
    [pbr::OriginalName("TYPING_START")] TypingStart = 0,
    [pbr::OriginalName("TYPING_STOP")] TypingStop = 1,
  }

  #endregion

  #region Messages
  public sealed partial class MessageId : pb::IMessage<MessageId> {
    private static readonly pb::MessageParser<MessageId> _parser = new pb::MessageParser<MessageId>(() => new MessageId());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MessageId> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.MessageTypesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageId() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageId(MessageId other) : this() {
      _hasBits0 = other._hasBits0;
      epoch_ = other.epoch_;
      position_ = other.position_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageId Clone() {
      return new MessageId(this);
    }

    /// <summary>Field number for the "epoch" field.</summary>
    public const int EpochFieldNumber = 1;
    private readonly static ulong EpochDefaultValue = 0UL;

    private ulong epoch_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Epoch {
      get { if ((_hasBits0 & 1) != 0) { return epoch_; } else { return EpochDefaultValue; } }
      set {
        _hasBits0 |= 1;
        epoch_ = value;
      }
    }
    /// <summary>Gets whether the "epoch" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasEpoch {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "epoch" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearEpoch() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "position" field.</summary>
    public const int PositionFieldNumber = 2;
    private readonly static ulong PositionDefaultValue = 0UL;

    private ulong position_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Position {
      get { if ((_hasBits0 & 2) != 0) { return position_; } else { return PositionDefaultValue; } }
      set {
        _hasBits0 |= 2;
        position_ = value;
      }
    }
    /// <summary>Gets whether the "position" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasPosition {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "position" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearPosition() {
      _hasBits0 &= ~2;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MessageId);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MessageId other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Epoch != other.Epoch) return false;
      if (Position != other.Position) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasEpoch) hash ^= Epoch.GetHashCode();
      if (HasPosition) hash ^= Position.GetHashCode();
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
      if (HasEpoch) {
        output.WriteRawTag(8);
        output.WriteUInt64(Epoch);
      }
      if (HasPosition) {
        output.WriteRawTag(16);
        output.WriteUInt64(Position);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasEpoch) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Epoch);
      }
      if (HasPosition) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Position);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MessageId other) {
      if (other == null) {
        return;
      }
      if (other.HasEpoch) {
        Epoch = other.Epoch;
      }
      if (other.HasPosition) {
        Position = other.Position;
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
            Epoch = input.ReadUInt64();
            break;
          }
          case 16: {
            Position = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
