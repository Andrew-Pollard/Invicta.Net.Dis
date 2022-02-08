using System;
using System.Buffers.Binary;


namespace Invicta.Net.Dis.Pdus {

	public class SimulationAddress : IDisSerializable {
		public const int Size = 4;


		public ushort SiteNumber { get; private set; }
		public ushort ApplicationNumber { get; private set; }


		public void DisSerialize(Span<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			BinaryPrimitives.WriteUInt16BigEndian(bytes[0..2], SiteNumber);
			BinaryPrimitives.WriteUInt16BigEndian(bytes[2..4], ApplicationNumber);
		}


		public void DisDeserialize(ReadOnlySpan<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			SiteNumber = BinaryPrimitives.ReadUInt16BigEndian(bytes[0..2]);
			ApplicationNumber = BinaryPrimitives.ReadUInt16BigEndian(bytes[2..4]);
		}
	}
}
