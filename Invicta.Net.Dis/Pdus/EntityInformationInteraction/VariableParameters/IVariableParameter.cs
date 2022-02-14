using Invicta.Net.SisoRef010;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction {

	public interface IVariableParameter : IDisSerializable {
		VariableParameterRecordType RecordType { get; }
	}
}