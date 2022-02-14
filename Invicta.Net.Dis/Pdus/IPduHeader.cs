using Invicta.Net.SisoRef010;


namespace Invicta.Net.Dis.Pdus {

	public interface IPduHeader : IDisSerializable {
		byte ExerciseIdentifier { get; }
		ushort Length { get; }
		DISPDUType PduType { get; }
		DISProtocolFamily ProtocolFamily { get; }
		DISProtocolVersion ProtocolVersion { get; }
		uint Timestamp { get; }
	}
}