using Invicta.Collections.Specialized;

using System.Reflection;
using System.Text;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction.Capabilities {

	public class ExpendableCapabilities : IEntityCapabilities {
		protected uint Reserved {
			get => Bits[0..5];
			set => Bits[0..5] = value;
		}

		public uint Capabilities {
			get => Bits.Raw;
			set => Bits.Raw = value;
		}

		private Bitfield32 Bits;


		public ExpendableCapabilities() {
			Bits = new();
		}

		public ExpendableCapabilities(uint capabilities) {
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
