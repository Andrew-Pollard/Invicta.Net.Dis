using Invicta.Collections.Specialized;
using Invicta.Net.SisoRef010;


namespace Invicta.Net.Dis.Pdus.Status {

	public class PduStatus : IDisSerializable {
		public const int Size = 1;


		public DISPDUStatusTransferredEntityIndicatorTEI TransferredEntityIndicator {
			get => (DISPDUStatusTransferredEntityIndicatorTEI) Bits[0..1];
			set => Bits[0..1] = (byte) value;
		}

		public DISPDUStatusLVCIndicatorLVC LVCIndicator {
			get => (DISPDUStatusLVCIndicatorLVC) Bits[1..3];
			set => Bits[1..3] = (byte) value;
		}

		public DISPDUStatusCoupledExtensionIndicatorCEI CoupledExtensionIndicator {
			get => (DISPDUStatusCoupledExtensionIndicatorCEI) Bits[3..4];
			set => Bits[3..4] = (byte) value;
		}

		public DISPDUStatusFireTypeIndicatorFTI FireTypeIndicator {
			get => (DISPDUStatusFireTypeIndicatorFTI) Bits[4..5];
			set => Bits[4..5] = (byte) value;
		}

		public DISPDUStatusDetonationTypeIndicatorDTI DetonationTypeIndicator {
			get => (DISPDUStatusDetonationTypeIndicatorDTI) Bits[4..6];
			set => Bits[4..6] = (byte) value;
		}

		public DISPDUStatusRadioAttachedIndicatorRAI RadioAttachedIndicator {
			get => (DISPDUStatusRadioAttachedIndicatorRAI) Bits[4..6];
			set => Bits[4..6] = (byte) value;
		}

		public DISPDUStatusIntercomAttachedIndicatorIAI IntercomAttachedIndicator {
			get => (DISPDUStatusIntercomAttachedIndicatorIAI) Bits[4..6];
			set => Bits[4..6] = (byte) value;
		}

		public DISPDUStatusIFFSimulationModeISM IFFSimulationMode {
			get => (DISPDUStatusIFFSimulationModeISM) Bits[4..5];
			set => Bits[4..5] = (byte) value;
		}

		public DISPDUStatusActiveInterrogationIndicatorAII ActiveInterrogationIndicator {
			get => (DISPDUStatusActiveInterrogationIndicatorAII) Bits[5..6];
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
			DISPDUStatusTransferredEntityIndicatorTEI transferredEntityIndicator,
			DISPDUStatusLVCIndicatorLVC lvcIndicator,
			DISPDUStatusCoupledExtensionIndicatorCEI coupledExtensionIndicator
		) : this() {
			TransferredEntityIndicator = transferredEntityIndicator;
			LVCIndicator = lvcIndicator;
			CoupledExtensionIndicator = coupledExtensionIndicator;
		}

		public PduStatus(
			DISPDUStatusLVCIndicatorLVC lvcIndicator,
			DISPDUStatusCoupledExtensionIndicatorCEI coupledExtensionIndicator,
			DISPDUStatusFireTypeIndicatorFTI fireTypeIndicator
		) : this() {
			LVCIndicator = lvcIndicator;
			CoupledExtensionIndicator = coupledExtensionIndicator;
			FireTypeIndicator = fireTypeIndicator;
		}

		public PduStatus(
			DISPDUStatusLVCIndicatorLVC lvcIndicator,
			DISPDUStatusCoupledExtensionIndicatorCEI coupledExtensionIndicator,
			DISPDUStatusDetonationTypeIndicatorDTI detonationTypeIndicator
		) : this() {
			LVCIndicator = lvcIndicator;
			CoupledExtensionIndicator = coupledExtensionIndicator;
			DetonationTypeIndicator = detonationTypeIndicator;
		}

		public PduStatus(
			DISPDUStatusLVCIndicatorLVC lvcIndicator,
			DISPDUStatusCoupledExtensionIndicatorCEI coupledExtensionIndicator
		) : this() {
			LVCIndicator = lvcIndicator;
			CoupledExtensionIndicator = coupledExtensionIndicator;
		}

		public PduStatus(
			DISPDUStatusTransferredEntityIndicatorTEI transferredEntityIndicator,
			DISPDUStatusLVCIndicatorLVC lvcIndicator,
			DISPDUStatusCoupledExtensionIndicatorCEI coupledExtensionIndicator,
			DISPDUStatusRadioAttachedIndicatorRAI radioAttachedIndicator
		) : this() {
			TransferredEntityIndicator = transferredEntityIndicator;
			LVCIndicator = lvcIndicator;
			CoupledExtensionIndicator = coupledExtensionIndicator;
			RadioAttachedIndicator = radioAttachedIndicator;
		}

		public PduStatus(
			DISPDUStatusTransferredEntityIndicatorTEI transferredEntityIndicator,
			DISPDUStatusLVCIndicatorLVC lvcIndicator,
			DISPDUStatusCoupledExtensionIndicatorCEI coupledExtensionIndicator,
			DISPDUStatusIFFSimulationModeISM iffSimulationMode,
			DISPDUStatusActiveInterrogationIndicatorAII activeInterrogationIndicator
		) : this() {
			TransferredEntityIndicator = transferredEntityIndicator;
			LVCIndicator = lvcIndicator;
			CoupledExtensionIndicator = coupledExtensionIndicator;
			IFFSimulationMode = iffSimulationMode;
			ActiveInterrogationIndicator = activeInterrogationIndicator;
		}

		public PduStatus(
			DISPDUStatusTransferredEntityIndicatorTEI transferredEntityIndicator,
			DISPDUStatusLVCIndicatorLVC lvcIndicator,
			DISPDUStatusCoupledExtensionIndicatorCEI coupledExtensionIndicator,
			DISPDUStatusIntercomAttachedIndicatorIAI intercomAttachedIndicator
		) : this() {
			TransferredEntityIndicator = transferredEntityIndicator;
			LVCIndicator = lvcIndicator;
			CoupledExtensionIndicator = coupledExtensionIndicator;
			IntercomAttachedIndicator = intercomAttachedIndicator;
		}

		public PduStatus(DISPDUStatusLVCIndicatorLVC lvcIndicator) : this() {
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
