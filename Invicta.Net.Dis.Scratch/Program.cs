using Invicta.Collections.Specialized;
using Invicta.Net.Dis.Pdus.EntityInformationInteraction;
using Invicta.Net.Dis.Pdus.EntityInformationInteraction.Appearance;
using Invicta.Net.Dis.Pdus.EntityInformationInteraction.Capabilities;


namespace Invicta.Net.Dis.Scratch {

	class Program {
		static void Main(string[] args) {
			Bitfield8 x = new();

			x[0..1] = 10;
		}
	}
}
