using Invicta.Net.SisoRef010;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction.VariableParameters {

	public class ArticulatedPartType : IDisSerializable {
		public const int Size = 4;


		public ArticulatedPartsTypeMetric Metric { get; }



		public void DisSerialize(Span<byte> bytes) {
			throw new NotImplementedException();
		}

		public void DisDeserialize(ReadOnlySpan<byte> bytes) {
			throw new NotImplementedException();
		}
	}
}
