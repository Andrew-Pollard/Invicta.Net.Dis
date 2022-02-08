using System;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction {

	public class EntityMarking : IDisSerializable {
		public const int Size = 12;


		public CharacterSet CharacterSet { get; private set; }

		public byte FirstCharacter { get; private set; }
		public byte SecondCharacter { get; private set; }
		public byte ThirdCharacter { get; private set; }
		public byte FourthCharacter { get; private set; }
		public byte FifthCharacter { get; private set; }
		public byte SixthCharacter { get; private set; }
		public byte SeventhCharacter { get; private set; }
		public byte EighthCharacter { get; private set; }
		public byte NinthCharacter { get; private set; }
		public byte TenthCharacter { get; private set; }
		public byte EleventhCharacter { get; private set; }


		public void DisSerialize(Span<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			bytes[0] = (byte) CharacterSet;

			bytes[1] = FirstCharacter;
			bytes[2] = SecondCharacter;
			bytes[3] = ThirdCharacter;
			bytes[4] = FourthCharacter;
			bytes[5] = FifthCharacter;
			bytes[6] = SixthCharacter;
			bytes[7] = SeventhCharacter;
			bytes[8] = EighthCharacter;
			bytes[9] = NinthCharacter;
			bytes[10] = TenthCharacter;
			bytes[11] = EleventhCharacter;
		}


		public void DisDeserialize(ReadOnlySpan<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			CharacterSet = (CharacterSet) bytes[0];

			FirstCharacter = bytes[1];
			SecondCharacter = bytes[2];
			ThirdCharacter = bytes[3];
			FourthCharacter = bytes[4];
			FifthCharacter = bytes[5];
			SixthCharacter = bytes[6];
			SeventhCharacter = bytes[7];
			EighthCharacter = bytes[8];
			NinthCharacter = bytes[9];
			TenthCharacter = bytes[10];
			EleventhCharacter = bytes[11];
		}
	}
}
