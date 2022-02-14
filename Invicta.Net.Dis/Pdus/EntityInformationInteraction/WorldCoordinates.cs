using System.Buffers.Binary;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction {

	public struct WorldCoordinates : IDisSerializable {
		public const int Size = 24;


		public double XCoordinate { get; private set; }
		public double YCoordinate { get; private set; }
		public double ZCoordinate { get; private set; }


		public void DisSerialize(Span<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			BinaryPrimitives.WriteDoubleBigEndian(bytes[0..8], XCoordinate);
			BinaryPrimitives.WriteDoubleBigEndian(bytes[8..16], YCoordinate);
			BinaryPrimitives.WriteDoubleBigEndian(bytes[16..24], ZCoordinate);
		}


		public void DisDeserialize(ReadOnlySpan<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			XCoordinate = BinaryPrimitives.ReadDoubleBigEndian(bytes[0..8]);
			YCoordinate = BinaryPrimitives.ReadDoubleBigEndian(bytes[8..16]);
			ZCoordinate = BinaryPrimitives.ReadDoubleBigEndian(bytes[16..24]);
		}
	}
}
