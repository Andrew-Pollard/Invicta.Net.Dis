using System.Buffers.Binary;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction {

	public struct AngularVelocityVector : IDisSerializable {
		public const int Size = 12;


		public float RateAboutXAxis { get; private set; }
		public float RateAboutYAxis { get; private set; }
		public float RateAboutZAxis { get; private set; }


		public void DisSerialize(Span<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			BinaryPrimitives.WriteSingleBigEndian(bytes[0..4], RateAboutXAxis);
			BinaryPrimitives.WriteSingleBigEndian(bytes[4..8], RateAboutYAxis);
			BinaryPrimitives.WriteSingleBigEndian(bytes[8..12], RateAboutZAxis);
		}


		public void DisDeserialize(ReadOnlySpan<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			RateAboutXAxis = BinaryPrimitives.ReadSingleBigEndian(bytes[0..4]);
			RateAboutYAxis = BinaryPrimitives.ReadSingleBigEndian(bytes[4..8]);
			RateAboutZAxis = BinaryPrimitives.ReadSingleBigEndian(bytes[8..12]);
		}
	}
}
