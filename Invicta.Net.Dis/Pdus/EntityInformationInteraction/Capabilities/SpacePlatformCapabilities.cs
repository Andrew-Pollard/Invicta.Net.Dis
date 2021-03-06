using Invicta.Collections.Specialized;

using System.Reflection;
using System.Text;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction.Capabilities {

	public class SpacePlatformCapabilities : IEntityCapabilities {
		public bool AmmunitionSupply {
			get => Bits[0];
			set => Bits[0] = value;
		}

		public bool FuelSupply {
			get => Bits[1];
			set => Bits[1] = value;
		}

		public bool Recovery {
			get => Bits[2];
			set => Bits[2] = value;
		}

		public bool Repair {
			get => Bits[3];
			set => Bits[3] = value;
		}

		protected bool Reserved {
			get => Bits[4];
			set => Bits[4] = value;
		}

		public uint Capabilities {
			get => Bits.Raw;
			set => Bits.Raw = value;
		}

		private Bitfield32 Bits;


		public SpacePlatformCapabilities() {
			Bits = new();
		}

		public SpacePlatformCapabilities(uint capabilities) {
			Bits = new(capabilities);
		}


		public override string ToString() {
			var Properties = GetType().GetProperties(
				BindingFlags.Public | BindingFlags.Instance
			);

			StringBuilder Builder = new();
			for (int i = 0; i < Properties.Length - 1; i++)
				Builder.Append($"{Properties[i].Name}: {Properties[i].GetValue(this)}, ");

			var Property = Properties.LastOrDefault();
			if (Property != null)
				Builder.Append($"{Property.Name}: {Property.GetValue(this)}");

			return Builder.ToString();
		}
	}
}
