using System;
using System.Buffers.Binary;


namespace Invicta.Net.Dis.Pdus {

	public class LePduHeader : IPduHeader {
		public const int Size = 12;


		public ProtocolVersion ProtocolVersion { get; private set; }
		public byte ExerciseIdentifier { get; private set; }
		public PduType PduType { get; private set; }
		public ProtocolFamily ProtocolFamily { get; private set; }
		public uint Timestamp { get; private set; }
		public ushort Length { get; private set; }
		public LiveEntitySubprotocolNumber SubprotocolNumber { get; private set; }
		public byte Padding { get; private set; }


		public LePduHeader() { }


		public LePduHeader(ProtocolVersion protocolVersion, byte exerciseIdentifier, PduType pduType, ProtocolFamily protocolFamily, uint timestamp, ushort length, LiveEntitySubprotocolNumber subprotocolNumber) {
			ProtocolVersion = protocolVersion;
			ExerciseIdentifier = exerciseIdentifier;
			PduType = pduType;
			ProtocolFamily = protocolFamily;
			Timestamp = timestamp;
			Length = length;
			SubprotocolNumber = subprotocolNumber;
		}


		public LePduHeader(ProtocolVersion protocolVersion, byte exerciseIdentifier, PduType pduType, ProtocolFamily protocolFamily, uint timestamp, ushort length, LiveEntitySubprotocolNumber subprotocolNumber, byte padding) : this(protocolVersion, exerciseIdentifier, pduType, protocolFamily, timestamp, length, subprotocolNumber) {
			ProtocolVersion = protocolVersion;
			ExerciseIdentifier = exerciseIdentifier;
			PduType = pduType;
			ProtocolFamily = protocolFamily;
			Timestamp = timestamp;
			Length = length;
			SubprotocolNumber = subprotocolNumber;
			Padding = padding;
		}


		public void DisSerialize(Span<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			bytes[0] = (byte) ProtocolVersion;
			bytes[1] = ExerciseIdentifier;
			bytes[2] = (byte) PduType;
			bytes[3] = (byte) ProtocolFamily;
			BinaryPrimitives.WriteUInt32BigEndian(bytes[4..8], Timestamp);
			BinaryPrimitives.WriteUInt16BigEndian(bytes[8..10], Length);
			bytes[10] = (byte) SubprotocolNumber;
			bytes[11] = Padding;
		}


		public void DisDeserialize(ReadOnlySpan<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			ProtocolVersion = (ProtocolVersion) bytes[0];
			ExerciseIdentifier = bytes[1];
			PduType = (PduType) bytes[2];
			ProtocolFamily = (ProtocolFamily) bytes[3];
			Timestamp = BinaryPrimitives.ReadUInt32BigEndian(bytes[4..8]);
			Length = BinaryPrimitives.ReadUInt16BigEndian(bytes[8..10]);
			SubprotocolNumber = (LiveEntitySubprotocolNumber) bytes[10];
			Padding = bytes[11];
		}
	}
}
