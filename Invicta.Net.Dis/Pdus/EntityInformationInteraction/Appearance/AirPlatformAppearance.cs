using Invicta.Collections.Specialized;
using Invicta.Net.SisoRef010;

using System.Linq;
using System.Reflection;
using System.Text;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction.Appearance {

	public class AirPlatformAppearance : IEntityAppearance {
		public AppearancePaintScheme PaintScheme {
			get => (AppearancePaintScheme) Bits[0..1];
			set => Bits[0..1] = (uint) value;
		} // 378

		public bool MobilityOrPropulsionKilled {
			get => Bits[1];
			set => Bits[1] = value;
		}

		public AppearanceNVGMode NvgMode {
			get => (AppearanceNVGMode) Bits[2..3];
			set => Bits[2..3] = (uint) value;
		} // 400

		public AppearanceDamage Damage {
			get => (AppearanceDamage) Bits[3..5];
			set => Bits[3..5] = (uint) value;
		} // 379

		public bool IsSmokeOrVaporEmanating {
			get => Bits[5];
			set => Bits[5] = value;
		}

		public bool IsEngineEmittingSmoke {
			get => Bits[6];
			set => Bits[6] = value;
		}

		public AppearanceTrailingEffects TrailingEffects {
			get => (AppearanceTrailingEffects) Bits[7..9];
			set => Bits[7..9] = (uint) value;
		} // 381

		public AppearanceCanopy CanopyOrTroopDoor {
			get => (AppearanceCanopy) Bits[9..12];
			set => Bits[9..12] = (uint) value;
		} // 387

		public bool LandingLightsOn {
			get => Bits[12];
			set => Bits[12] = value;
		}

		public bool NavigationLightsOn {
			get => Bits[13];
			set => Bits[13] = value;
		}

		public bool AntiCollisionLightsOn {
			get => Bits[14];
			set => Bits[14] = value;
		}

		public bool IsFlaming {
			get => Bits[15];
			set => Bits[15] = value;
		}

		public bool AfterburnerOn {
			get => Bits[16];
			set => Bits[16] = value;
		}

		public bool LowerAntiCollisionLightOn {
			get => Bits[17];
			set => Bits[17] = value;
		}

		public bool UpperAntiCollisionLightOn {
			get => Bits[18];
			set => Bits[18] = value;
		}

		public AppearanceAntiCollisionDayOrNight AntiCollisionDayOrNight {
			get => (AppearanceAntiCollisionDayOrNight) Bits[19..20];
			set => Bits[19..20] = (uint) value;
		} // 397

		public bool IsBlinking {
			get => Bits[20];
			set => Bits[20] = value;
		}

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

		public bool FormationLightsOn {
			get => Bits[24];
			set => Bits[24] = value;
		}

		public bool LandingGearExtended {
			get => Bits[25];
			set => Bits[25] = value;
		}

		public bool CargoDoorsOpened {
			get => Bits[26];
			set => Bits[26] = value;
		}

		public AppearanceNavigationOrPositionBrightness NavigationOrPositionBrightness {
			get => (AppearanceNavigationOrPositionBrightness) Bits[27..28];
			set => Bits[27..28] = (uint) value;
		} // 398

		public bool SpotOrSearchLight1On {
			get => Bits[28];
			set => Bits[28] = value;
		}

		public bool InteriorLightsOn {
			get => Bits[29];
			set => Bits[29] = value;
		}

		public bool ReverseThrustEngaged {
			get => Bits[30];
			set => Bits[30] = value;
		}

		public bool WeightOnWheels {
			get => Bits[31];
			set => Bits[31] = value;
		}

		public uint Appearance {
			get => Bits.Raw;
			set => Bits.Raw = value;
		}

		private Bitfield32 Bits;


		public AirPlatformAppearance() {
			Bits = new();
		}

		public AirPlatformAppearance(uint appearance) {
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
