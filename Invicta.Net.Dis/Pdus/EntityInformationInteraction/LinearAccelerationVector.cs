using System.Buffers.Binary;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction {

	public struct LinearAccelerationVector : IDisSerializable {
		public const int Size = 12;


		public float X { get; private set; }
		public float Y { get; private set; }
		public float Z { get; private set; }


		public void DisSerialize(Span<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			BinaryPrimitives.WriteSingleBigEndian(bytes[0..4], X);
			BinaryPrimitives.WriteSingleBigEndian(bytes[4..8], Y);
			BinaryPrimitives.WriteSingleBigEndian(bytes[8..12], Z);
		}


		public void DisDeserialize(ReadOnlySpan<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			X = BinaryPrimitives.ReadSingleBigEndian(bytes[0..4]);
			Y = BinaryPrimitives.ReadSingleBigEndian(bytes[4..8]);
			Z = BinaryPrimitives.ReadSingleBigEndian(bytes[8..12]);
		}
	}
}
