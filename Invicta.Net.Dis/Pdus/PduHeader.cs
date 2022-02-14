using Invicta.Net.Dis.Pdus.Status;
using Invicta.Net.SisoRef010;

using System.Buffers.Binary;


namespace Invicta.Net.Dis.Pdus {

	public class PduHeader : IPduHeader {
		public const int Size = 12;


		public DISProtocolVersion ProtocolVersion { get; private set; }
		public byte ExerciseIdentifier { get; private set; }
		public DISPDUType PduType { get; private set; }
		public DISProtocolFamily ProtocolFamily { get; private set; }
		public uint Timestamp { get; private set; }
		public ushort Length { get; private set; }
		public PduStatus PduStatus { get; private set; }
		protected byte Padding { get; private set; }


		public PduHeader() { }

		public PduHeader(
			DISProtocolVersion protocolVersion,
			byte exerciseIdentifier,
			DISPDUType pduType,
			DISProtocolFamily protocolFamily,
			byte timestamp,
			byte length,
			PduStatus pduStatus
		) {
			ProtocolVersion = protocolVersion;
			ExerciseIdentifier = exerciseIdentifier;
			PduType = pduType;
			ProtocolFamily = protocolFamily;
			Timestamp = timestamp;
			Length = length;
			PduStatus = pduStatus;
		}

		protected PduHeader(
			DISProtocolVersion protocolVersion,
			byte exerciseIdentifier,
			DISPDUType pduType,
			DISProtocolFamily protocolFamily,
			byte timestamp,
			byte length,
			PduStatus pduStatus,
			byte padding
		) {
			ProtocolVersion = protocolVersion;
			ExerciseIdentifier = exerciseIdentifier;
			PduType = pduType;
			ProtocolFamily = protocolFamily;
			Timestamp = timestamp;
			Length = length;
			PduStatus = pduStatus;
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
			PduStatus.DisSerialize(bytes[10..11]);
			bytes[11] = Padding;
		}


		public void DisDeserialize(ReadOnlySpan<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			ProtocolVersion = (DISProtocolVersion) bytes[0];
			ExerciseIdentifier = bytes[1];
			PduType = (DISPDUType) bytes[2];
			ProtocolFamily = (DISProtocolFamily) bytes[3];
			Timestamp = BinaryPrimitives.ReadUInt32BigEndian(bytes[4..8]);
			Length = BinaryPrimitives.ReadUInt16BigEndian(bytes[8..10]);
			PduStatus.DisDeserialize(bytes[10..11]);
			Padding = bytes[11];
		}
	}
}
