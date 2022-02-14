using Invicta.Net.SisoRef010;

using System.Buffers.Binary;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction {

	public class EntityType : IDisSerializable {
		public const int Size = 8;


		public EntityKind EntityKind { get; private set; }
		public byte Domain { get; private set; }
		public Country Country { get; private set; }
		public byte Category { get; private set; }
		public byte Subcategory { get; private set; }
		public byte Specific { get; private set; }
		public byte Extra { get; private set; }


		public void DisSerialize(Span<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			bytes[0] = (byte) EntityKind;
			bytes[1] = Domain;
			BinaryPrimitives.WriteUInt16BigEndian(bytes[2..4], (ushort) Country);
			bytes[4] = Category;
			bytes[5] = Subcategory;
			bytes[6] = Specific;
			bytes[7] = Extra;
		}


		public void DisDeserialize(ReadOnlySpan<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			EntityKind = (EntityKind) bytes[0];
			Domain = bytes[1];
			Country = (Country) BinaryPrimitives.ReadUInt16BigEndian(bytes[2..4]);
			Category = bytes[4];
			Subcategory = bytes[5];
			Specific = bytes[6];
			Extra = bytes[7];
		}
	}
}
