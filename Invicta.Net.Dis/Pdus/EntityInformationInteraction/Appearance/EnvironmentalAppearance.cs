using Invicta.Collections.Specialized;

using System.Linq;
using System.Reflection;
using System.Text;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction.Appearance {

	public class EnvironmentalAppearance : IEntityAppearance {
		public EnvironmentalDensity Density {
			get => (EnvironmentalDensity) Bits[16..19];
			set => Bits[16..19] = (uint) value;
		} // 395

		public bool IsFrozen {
			get => Bits[21];
			set => Bits[21] = value;
		}

		public EntityOrObjectState State {
			get => (EntityOrObjectState) Bits[23..24];
			set => Bits[23..24] = (uint) value;
		} // 386

		public bool MaskedOrCloaked {
			get => Bits[31];
			set => Bits[31] = value;
		}


		public uint Appearance {
			get => Bits.Raw;
			set => Bits.Raw = value;
		}

		private Bitfield32 Bits;


		public EnvironmentalAppearance() {
			Bits = new();
		}

		public EnvironmentalAppearance(uint appearance) {
			Bits = new(appearance);
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
