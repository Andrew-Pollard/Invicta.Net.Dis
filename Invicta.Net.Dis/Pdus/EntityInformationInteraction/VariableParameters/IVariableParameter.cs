namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction {

	public interface IVariableParameter : IDisSerializable {
		VariableParameterRecordType RecordType { get; }
	}
}