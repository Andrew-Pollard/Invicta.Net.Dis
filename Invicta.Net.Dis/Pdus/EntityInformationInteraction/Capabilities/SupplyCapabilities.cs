using Invicta.Collections.Specialized;

using System.Reflection;
using System.Text;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction.Capabilities {

	public class SupplyCapabilities : IEntityCapabilities {
		public bool AmmunitionSupply {
			get => Bits[0];
			set => Bits[0] = value;
		}

		public bool FuelSupply {
			get => Bits[1];
			set => Bits[1] = value;
		}

		protected uint Reserved {
			get => Bits[2..5];
			set => Bits[2..5] = value;
		}

		public bool SlingLoadable {
			get => Bits[6];
			set => Bits[6] = value;
		}

		public bool IedPresenceIndicator {
			get => Bits[7];
			set => Bits[7] = value;
		}

		public uint Capabilities {
			get => Bits.Raw;
			set => Bits.Raw = value;
		}

		private Bitfield32 Bits;


		public SupplyCapabilities() {
			Bits = new();
		}

		public SupplyCapabilities(uint capabilities) {
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
