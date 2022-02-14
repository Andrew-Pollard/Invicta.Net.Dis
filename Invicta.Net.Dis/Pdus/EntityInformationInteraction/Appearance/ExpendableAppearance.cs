using Invicta.Collections.Specialized;
using Invicta.Net.SisoRef010;

using System.Reflection;
using System.Text;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction.Appearance {
	public class ExpendableAppearance : IEntityAppearance {
		public AppearanceDamage Damage {
			get => (AppearanceDamage) Bits[3..5];
			set => Bits[3..5] = (uint) value;
		} // 379

		public bool IsSmokeEmanating {
			get => Bits[5];
			set => Bits[5] = value;
		}

		public Parachute ParachuteStatus {
			get => (Parachute) Bits[7..9];
			set => Bits[7..9] = (uint) value;
		} // 401

		public FlareOrSmokeColor FlareOrSmokeColor {
			get => (FlareOrSmokeColor) Bits[9..12];
			set => Bits[9..12] = (uint) value;
		} // 402

		public bool IsFlaming {
			get => Bits[15];
			set => Bits[15] = value;
		}

		public bool LaunchFlashPresent {
			get => Bits[16];
			set => Bits[16] = value;
		}

		public FlareOrSmokeStatus FlareOrSmokeStatus {
			get => (FlareOrSmokeStatus) Bits[17..19];
			set => Bits[17..19] = (uint) value;
		} // 403

		public bool IsFrozen {
			get => Bits[21];
			set => Bits[21] = value;
		}

		public bool PowerPlantOn {
			get => Bits[22];
			set => Bits[22] = value;
		}

		public AppearanceEntityOrObjectState State {
			get => (AppearanceEntityOrObjectState) Bits[23..24];
			set => Bits[23..24] = (uint) value;
		} // 386

		public SpotChaffStatus SpotChaffStatus {
			get => (SpotChaffStatus) Bits[24..26];
			set => Bits[24..26] = (uint) value;
		} // 404

		public bool MaskedOrCloaked {
			get => Bits[31];
			set => Bits[31] = value;
		}

		public uint Appearance {
			get => Bits.Raw;
			set => Bits.Raw = value;
		}

		private Bitfield32 Bits;


		public ExpendableAppearance() {
			Bits = new();
		}

		public ExpendableAppearance(uint appearance) {
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
