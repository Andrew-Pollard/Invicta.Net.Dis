using System;


namespace Invicta.Net.Dis.Pdus.Status {

	public class PduStatus : IPduStatus {
		public const int Size = 1;


		public TransferredEntityIndicator TransferredEntityIndicator {
			get => (TransferredEntityIndicator) (Status & 0b0000_0001);
			private set => Status |= (byte) ((int) value & 0b0000_0001);
		}

		public LVCIndicator LVCIndicator {
			get => (LVCIndicator) ((Status & 0b0000_0110) >> 1);
			private set => Status |= (byte) (((int) value & 0b0000_0110) >> 1);
		}

		public CoupledExtensionIndicator CoupledExtensionIndicator {
			get => (CoupledExtensionIndicator) ((Status & 0b0000_1000) >> 3);
			private set => Status |= (byte) (((int) value & 0b0000_1000) >> 3);
		}

		public FireTypeIndicator FireTypeIndicator {
			get => (FireTypeIndicator) ((Status & 0b0001_0000) >> 4);
			private set => Status |= (byte) (((int) value & 0b0001_0000) >> 4);
		}

		public DetonationTypeIndicator DetonationTypeIndicator {
			get => (DetonationTypeIndicator) ((Status & 0b0011_0000) >> 4);
			private set => Status |= (byte) (((int) value & 0b0011_0000) >> 4);
		}

		public RadioAttachedIndicator RadioAttachedIndicator {
			get => (RadioAttachedIndicator) ((Status & 0b0011_0000) >> 4);
			private set => Status |= (byte) (((int) value & 0b0011_0000) >> 4);
		}

		public IntercomAttachedIndicator IntercomAttachedIndicator {
			get => (IntercomAttachedIndicator) ((Status & 0b0011_0000) >> 4);
			private set => Status |= (byte) (((int) value & 0b0011_0000) >> 4);
		}

		public IFFSimulationMode IFFSimulationMode {
			get => (IFFSimulationMode) ((Status & 0b0001_0000) >> 4);
			private set => Status |= (byte) (((int) value & 0b0001_0000) >> 4);
		}

		public ActiveInterrogationIndicator ActiveInterrogationIndicator {
			get => (ActiveInterrogationIndicator) ((Status & 0b0010_0000) >> 5);
			private set => Status |= (byte) (((int) value & 0b0010_0000) >> 5);
		}


		protected byte Status { get; private set; }


		public PduStatus() { }


		public PduStatus(
			TransferredEntityIndicator transferredEntityIndicator,
			LVCIndicator lvcIndicator,
			CoupledExtensionIndicator coupledExtensionIndicator
		) {
			TransferredEntityIndicator = transferredEntityIndicator;
			LVCIndicator = lvcIndicator;
			CoupledExtensionIndicator = coupledExtensionIndicator;
		}

		public PduStatus(
			LVCIndicator lvcIndicator,
			CoupledExtensionIndicator coupledExtensionIndicator,
			FireTypeIndicator fireTypeIndicator
		) {
			LVCIndicator = lvcIndicator;
			CoupledExtensionIndicator = coupledExtensionIndicator;
			FireTypeIndicator = fireTypeIndicator;
		}

		public PduStatus(
			LVCIndicator lvcIndicator,
			CoupledExtensionIndicator coupledExtensionIndicator,
			DetonationTypeIndicator detonationTypeIndicator
		) {
			LVCIndicator = lvcIndicator;
			CoupledExtensionIndicator = coupledExtensionIndicator;
			DetonationTypeIndicator = detonationTypeIndicator;
		}

		public PduStatus(
			LVCIndicator lvcIndicator,
			CoupledExtensionIndicator coupledExtensionIndicator
		) {
			LVCIndicator = lvcIndicator;
			CoupledExtensionIndicator = coupledExtensionIndicator;
		}

		public PduStatus(
			TransferredEntityIndicator transferredEntityIndicator,
			LVCIndicator lvcIndicator,
			CoupledExtensionIndicator coupledExtensionIndicator,
			RadioAttachedIndicator radioAttachedIndicator
		) {
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
		) {
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
		) {
			TransferredEntityIndicator = transferredEntityIndicator;
			LVCIndicator = lvcIndicator;
			CoupledExtensionIndicator = coupledExtensionIndicator;
			IntercomAttachedIndicator = intercomAttachedIndicator;
		}

		public PduStatus(LVCIndicator lvcIndicator) {
			LVCIndicator = lvcIndicator;
		}


		protected PduStatus(byte @byte) {
			Status = @byte;
		}


		public void DisSerialize(Span<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			bytes[0] = Status;
		}


		public void DisDeserialize(ReadOnlySpan<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			Status = bytes[0];
		}
	}
}
