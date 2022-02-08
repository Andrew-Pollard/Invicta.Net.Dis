using Invicta.Collections.Specialized;


namespace Invicta.Net.Dis.Pdus.Status {

	public class PduStatus : IDisSerializable {
		public const int Size = 1;


		public TransferredEntityIndicator TransferredEntityIndicator {
			get => (TransferredEntityIndicator) Bits[0..1];
			set => Bits[0..1] = (byte) value;
		}

		public LVCIndicator LVCIndicator {
			get => (LVCIndicator) Bits[1..3];
			set => Bits[1..3] = (byte) value;
		}

		public CoupledExtensionIndicator CoupledExtensionIndicator {
			get => (CoupledExtensionIndicator) Bits[3..4];
			set => Bits[3..4] = (byte) value;
		}

		public FireTypeIndicator FireTypeIndicator {
			get => (FireTypeIndicator) Bits[4..5];
			set => Bits[4..5] = (byte) value;
		}

		public DetonationTypeIndicator DetonationTypeIndicator {
			get => (DetonationTypeIndicator) Bits[4..6];
			set => Bits[4..6] = (byte) value;
		}

		public RadioAttachedIndicator RadioAttachedIndicator {
			get => (RadioAttachedIndicator) Bits[4..6];
			set => Bits[4..6] = (byte) value;
		}

		public IntercomAttachedIndicator IntercomAttachedIndicator {
			get => (IntercomAttachedIndicator) Bits[4..6];
			set => Bits[4..6] = (byte) value;
		}

		public IFFSimulationMode IFFSimulationMode {
			get => (IFFSimulationMode) Bits[4..5];
			set => Bits[4..5] = (byte) value;
		}

		public ActiveInterrogationIndicator ActiveInterrogationIndicator {
			get => (ActiveInterrogationIndicator) Bits[5..6];
			set => Bits[5..6] = (byte) value;
		}


		public byte Status {
			get => Bits.Raw;
			set => Bits.Raw = value;
		}


		private Bitfield8 Bits;


		public PduStatus() {
			Bits = new Bitfield8();
		}


		public PduStatus(byte @byte) {
			Bits = new Bitfield8(@byte);
		}


		public PduStatus(
			TransferredEntityIndicator transferredEntityIndicator,
			LVCIndicator lvcIndicator,
			CoupledExtensionIndicator coupledExtensionIndicator
		) : this() {
			TransferredEntityIndicator = transferredEntityIndicator;
			LVCIndicator = lvcIndicator;
			CoupledExtensionIndicator = coupledExtensionIndicator;
		}

		public PduStatus(
			LVCIndicator lvcIndicator,
			CoupledExtensionIndicator coupledExtensionIndicator,
			FireTypeIndicator fireTypeIndicator
		) : this() {
			LVCIndicator = lvcIndicator;
			CoupledExtensionIndicator = coupledExtensionIndicator;
			FireTypeIndicator = fireTypeIndicator;
		}

		public PduStatus(
			LVCIndicator lvcIndicator,
			CoupledExtensionIndicator coupledExtensionIndicator,
			DetonationTypeIndicator detonationTypeIndicator
		) : this() {
			LVCIndicator = lvcIndicator;
			CoupledExtensionIndicator = coupledExtensionIndicator;
			DetonationTypeIndicator = detonationTypeIndicator;
		}

		public PduStatus(
			LVCIndicator lvcIndicator,
			CoupledExtensionIndicator coupledExtensionIndicator
		) : this() {
			LVCIndicator = lvcIndicator;
			CoupledExtensionIndicator = coupledExtensionIndicator;
		}

		public PduStatus(
			TransferredEntityIndicator transferredEntityIndicator,
			LVCIndicator lvcIndicator,
			CoupledExtensionIndicator coupledExtensionIndicator,
			RadioAttachedIndicator radioAttachedIndicator
		) : this() {
			TransferredEntityIndicator = transferredEntityIndicator;
			LVCIndicator = lvcIndicator;
			CoupledExtensionIndicator = coupledExtensionIndicator;
			RadioAttachedIndicator = radioAttachedIndicator;
		}

		public PduStatus(
			TransferredEntityIndicator transferredEntityIndicator,
			LVCIndicator lvcIndicator,
			CoupledExtensionIndicator coupledExtensionIndicator,
			IFFSimulationMode iffSimulationMode,
			ActiveInterrogationIndicator activeInterrogationIndicator
		) : this() {
			TransferredEntityIndicator = transferredEntityIndicator;
			LVCIndicator = lvcIndicator;
			CoupledExtensionIndicator = coupledExtensionIndicator;
			IFFSimulationMode = iffSimulationMode;
			ActiveInterrogationIndicator = activeInterrogationIndicator;
		}

		public PduStatus(
			TransferredEntityIndicator transferredEntityIndicator,
			LVCIndicator lvcIndicator,
			CoupledExtensionIndicator coupledExtensionIndicator,
			IntercomAttachedIndicator intercomAttachedIndicator
		) : this() {
			TransferredEntityIndicator = transferredEntityIndicator;
			LVCIndicator = lvcIndicator;
			CoupledExtensionIndicator = coupledExtensionIndicator;
			IntercomAttachedIndicator = intercomAttachedIndicator;
		}

		public PduStatus(LVCIndicator lvcIndicator) : this() {
			LVCIndicator = lvcIndicator;
		}


		public void DisSerialize(Span<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			bytes[0] = Bits.Raw;
		}


		public void DisDeserialize(ReadOnlySpan<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			Bits.Raw = bytes[0];
		}
	}
}
