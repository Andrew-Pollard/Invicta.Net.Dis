using System;
using System.Buffers.Binary;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction {

	public struct EulerAngles : IDisSerializable {
		public const int Size = 12;


		/// <remarks>ψ</remarks>
		public float Psi { get; private set; }

		/// <remarks>θ</remarks>
		public float Theta { get; private set; }

		/// <remarks>φ</remarks>
		public float Phi { get; private set; }


		public void DisSerialize(Span<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			BinaryPrimitives.WriteSingleBigEndian(bytes[0..4], Psi);
			BinaryPrimitives.WriteSingleBigEndian(bytes[4..8], Theta);
			BinaryPrimitives.WriteSingleBigEndian(bytes[8..12], Phi);
		}


		public void DisDeserialize(ReadOnlySpan<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			Psi = BinaryPrimitives.ReadSingleBigEndian(bytes[0..4]);
			Theta = BinaryPrimitives.ReadSingleBigEndian(bytes[4..8]);
			Phi = BinaryPrimitives.ReadSingleBigEndian(bytes[8..12]);
		}
	}
}
