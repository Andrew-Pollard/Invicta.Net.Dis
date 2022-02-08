using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction.VariableParameters {

	public class ArticulatedPartType : IDisSerializable {
		public const int Size = 4;


		public ArticulatedPartTypeMetric Metric { get; }



		public void DisSerialize(Span<byte> bytes) {
			throw new NotImplementedException();
		}

		public void DisDeserialize(ReadOnlySpan<byte> bytes) {
			throw new NotImplementedException();
		}
	}
}
