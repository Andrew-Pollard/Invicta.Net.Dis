using System;
using System.Buffers.Binary;


namespace Invicta.Net.Dis.Pdus {

	public class EntityIdentifier : IDisSerializable {
		public const int Size = 6;


		public SimulationAddress SimulationAddress { get; }
		public ushort EntityNumber { get; private set; }


		public void DisSerialize(Span<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			SimulationAddress.DisSerialize(bytes[0..4]);
			BinaryPrimitives.WriteUInt16BigEndian(bytes[4..6], EntityNumber);
		}


		public void DisDeserialize(ReadOnlySpan<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			SimulationAddress.DisDeserialize(bytes[0..4]);
			EntityNumber = BinaryPrimitives.ReadUInt16BigEndian(bytes[4..6]);
		}
	}
}
