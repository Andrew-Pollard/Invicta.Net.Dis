using Invicta.Collections.Specialized;

using System.Linq;
using System.Reflection;
using System.Text;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction.Appearance {

	public class CulturalFeatureAppearance : IEntityAppearance {
		public Damage Damage {
			get => (Damage) Bits[3..5];
			set => Bits[3..5] = (uint) value;
		} // 379

		public bool IsSmokeEmanating {
			get => Bits[5];
			set => Bits[5] = value;
		}

		public bool IsFlaming {
			get => Bits[15];
			set => Bits[15] = value;
		}

		public bool IsFrozen {
			get => Bits[21];
			set => Bits[21] = value;
		}

		public bool InternalHeatOn {
			get => Bits[22];
			set => Bits[22] = value;
		}

		public EntityOrObjectState State {
			get => (EntityOrObjectState) Bits[23..24];
			set => Bits[23..24] = (uint) value;
		} // 386

		public bool ExteriorLightsOn {
			get => Bits[28];
			set => Bits[28] = value;
		}

		public bool InteriorLightsOn {
			get => Bits[29];
			set => Bits[29] = value;
		}

		public bool MaskedOrCloaked {
			get => Bits[31];
			set => Bits[31] = value;
		}

		public uint Appearance {
			get => Bits.Raw;
			set => Bits.Raw = value;
		}

		private Bitfield32 Bits;


		public CulturalFeatureAppearance() {
			Bits = new();
		}

		public CulturalFeatureAppearance(uint appearance) {
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
