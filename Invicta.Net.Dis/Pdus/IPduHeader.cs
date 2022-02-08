namespace Invicta.Net.Dis.Pdus {

	public interface IPduHeader : IDisSerializable {
		byte ExerciseIdentifier { get; }
		ushort Length { get; }
		PduType PduType { get; }
		ProtocolFamily ProtocolFamily { get; }
		ProtocolVersion ProtocolVersion { get; }
		uint Timestamp { get; }
	}
}