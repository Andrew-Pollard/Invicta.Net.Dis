using Invicta.Net.SisoRef010;

using System.Buffers.Binary;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction {

	public class ArticulatedPartVariableParameter : IVariableParameter {
		public const int Size = 16;


		public VariableParameterRecordType RecordType { get; private set; }
		public byte ChangeIndicator { get; private set; }
		public ushort IdPartAttachedTo { get; private set; }
		public uint ParameterType { get; private set; }
		public float ParameterValue { get; private set; }
		protected byte[] Padding { get; } = new byte[4];


		public void DisSerialize(Span<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			bytes[0] = (byte) RecordType;
			bytes[1] = ChangeIndicator;
			BinaryPrimitives.WriteUInt16BigEndian(bytes[2..4], IdPartAttachedTo);
			BinaryPrimitives.WriteUInt32BigEndian(bytes[4..8], ParameterType);
			BinaryPrimitives.WriteSingleBigEndian(bytes[8..12], ParameterValue);
			Padding.CopyTo(bytes[12..16]);
		}


		public void DisDeserialize(ReadOnlySpan<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			RecordType = (VariableParameterRecordType) bytes[0];
			ChangeIndicator = bytes[1];
			IdPartAttachedTo = BinaryPrimitives.ReadUInt16BigEndian(bytes[2..4]);
			ParameterType = BinaryPrimitives.ReadUInt32BigEndian(bytes[4..8]);
			ParameterValue = BinaryPrimitives.ReadSingleBigEndian(bytes[8..12]);
			bytes[12..16].CopyTo(Padding);
		}
	}
}
