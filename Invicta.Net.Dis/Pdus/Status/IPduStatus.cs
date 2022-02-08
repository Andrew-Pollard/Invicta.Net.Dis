namespace Invicta.Net.Dis.Pdus.Status {

	public interface IPduStatus : IDisSerializable {
		ActiveInterrogationIndicator ActiveInterrogationIndicator { get; }
		CoupledExtensionIndicator CoupledExtensionIndicator { get; }
		DetonationTypeIndicator DetonationTypeIndicator { get; }
		FireTypeIndicator FireTypeIndicator { get; }
		IFFSimulationMode IFFSimulationMode { get; }
		IntercomAttachedIndicator IntercomAttachedIndicator { get; }
		LVCIndicator LVCIndicator { get; }
		RadioAttachedIndicator RadioAttachedIndicator { get; }
		TransferredEntityIndicator TransferredEntityIndicator { get; }
	}
}