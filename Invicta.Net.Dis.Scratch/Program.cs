using Invicta.Net.Dis.Pdus.EntityInformationInteraction;
using Invicta.Net.Dis.Pdus.EntityInformationInteraction.Appearance;
using Invicta.Net.Dis.Pdus.EntityInformationInteraction.Capabilities;


namespace Invicta.Net.Dis.Scratch {

	class Program {
		static void Main(string[] args) {
			EntityStatePdu pdu = new() {
				Capabilities =		0b11001110_01001011_01001001_01111011u,
				EntityAppearance = ~0b11001110_01001011_01001001_01111011u
			};

			Console.WriteLine(new AirPlatformCapabilities(pdu.Capabilities));
			Console.WriteLine();
			Console.WriteLine(new CulturalFeatureCapabilities(pdu.Capabilities));
			Console.WriteLine();
			Console.WriteLine(new EnvironmentalCapabilities(pdu.Capabilities));
			Console.WriteLine();
			Console.WriteLine(new ExpendableCapabilities(pdu.Capabilities));
			Console.WriteLine();
			Console.WriteLine(new LandPlatformCapabilities(pdu.Capabilities));
			Console.WriteLine();
			Console.WriteLine(new LifeFormCapabilities(pdu.Capabilities));
			Console.WriteLine();
			Console.WriteLine(new MunitionCapabilities(pdu.Capabilities));
			Console.WriteLine();
			Console.WriteLine(new RadioCapabilities(pdu.Capabilities));
			Console.WriteLine();
			Console.WriteLine(new SensorOrEmitterCapabilities(pdu.Capabilities));
			Console.WriteLine();
			Console.WriteLine(new SpacePlatformCapabilities(pdu.Capabilities));
			Console.WriteLine();
			Console.WriteLine(new SubsurfacePlatformCapabilities(pdu.Capabilities));
			Console.WriteLine();
			Console.WriteLine(new SupplyCapabilities(pdu.Capabilities));
			Console.WriteLine();
			Console.WriteLine(new SurfacePlatformCapabilities(pdu.Capabilities));
			Console.WriteLine();

			Console.WriteLine();

			Console.WriteLine(new AirPlatformAppearance(pdu.EntityAppearance));
			Console.WriteLine();
			Console.WriteLine(new CulturalFeatureAppearance(pdu.EntityAppearance));
			Console.WriteLine();
			Console.WriteLine(new EnvironmentalAppearance(pdu.EntityAppearance));
			Console.WriteLine();
			Console.WriteLine(new ExpendableAppearance(pdu.EntityAppearance));
			Console.WriteLine();
			Console.WriteLine(new HumanLifeFormAppearance(pdu.EntityAppearance));
			Console.WriteLine();
			Console.WriteLine(new LandPlatformAppearance(pdu.EntityAppearance));
			Console.WriteLine();
			Console.WriteLine(new MunitionAppearance(pdu.EntityAppearance));
			Console.WriteLine();
			Console.WriteLine(new NonHumanLifeFormAppearance(pdu.EntityAppearance));
			Console.WriteLine();
			Console.WriteLine(new RadioAppearance(pdu.EntityAppearance));
			Console.WriteLine();
			Console.WriteLine(new SensorOrEmitterAppearance(pdu.EntityAppearance));
			Console.WriteLine();
			Console.WriteLine(new SpacePlatformAppearance(pdu.EntityAppearance));
			Console.WriteLine();
			Console.WriteLine(new SubsurfacePlatformAppearance(pdu.EntityAppearance));
			Console.WriteLine();
			Console.WriteLine(new SupplyAppearance(pdu.EntityAppearance));
			Console.WriteLine();
			Console.WriteLine(new SurfacePlatformAppearance(pdu.EntityAppearance));
		}
	}
}
