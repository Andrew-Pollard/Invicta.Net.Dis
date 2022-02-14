using Invicta.Collections.Specialized;
using Invicta.Net.SisoRef010;

using System.Reflection;
using System.Text;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction.Appearance {

	public class LandPlatformAppearance : IEntityAppearance {
		public AppearancePaintScheme PaintScheme {
			get => (AppearancePaintScheme) Bits[0..1];
			set => Bits[0..1] = (uint) value;
		} // 378

		public bool MobilityOrPropulsionKilled {
			get => Bits[1];
			set => Bits[1] = value;
		}

		public bool FirePowerKilled {
			get => Bits[2];
			set => Bits[2] = value;
		}

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

		public AppearanceTrailingEffects TrailingDustCloud {
			get => (AppearanceTrailingEffects) Bits[7..9];
			set => Bits[7..9] = (uint) value;
		} // 381

		public AppearanceHatch PrimaryHatch {
			get => (AppearanceHatch) Bits[9..12];
			set => Bits[9..12] = (uint) value;
		} // 382

		public bool HeadLightsOn {
			get => Bits[12];
			set => Bits[12] = value;
		}

		public bool TailLightsOn {
			get => Bits[13];
			set => Bits[13] = value;
		}

		public bool BrakeLightsOn {
			get => Bits[14];
			set => Bits[14] = value;
		}

		public bool IsFlaming {
			get => Bits[15];
			set => Bits[15] = value;
		}

		public AppearanceLauncherOrOperational LauncherOrOperational {
			get => (AppearanceLauncherOrOperational) Bits[16..17];
			set => Bits[16..17] = (uint) value;
		} // 383


		public AppearanceCamouflageType CamouflageType {
			get => (AppearanceCamouflageType) Bits[17..19];
			set => Bits[17..19] = (uint) value;
		} // 384

		public AppearanceConcealedPosition ConcealedPosition {
			get => (AppearanceConcealedPosition) Bits[19..20];
			set => Bits[19..20] = (uint) value;
		} // 385

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

		public bool TentExtended {
			get => Bits[24];
			set => Bits[24] = value;
		}

		public bool RampExtended {
			get => Bits[25];
			set => Bits[25] = value;
		}

		public bool BlackoutLightsOn {
			get => Bits[26];
			set => Bits[26] = value;
		}

		public bool BlackoutBrakeLightsOn {
			get => Bits[27];
			set => Bits[27] = value;
		}

		public bool SpotOrSearchLight1On {
			get => Bits[28];
			set => Bits[28] = value;
		}

		public bool InteriorLightsForwardOn {
			get => Bits[29];
			set => Bits[29] = value;
		}

		public bool OccupantsSurrendered {
			get => Bits[30];
			set => Bits[30] = value;
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


		public LandPlatformAppearance() {
			Bits = new();
		}

		public LandPlatformAppearance(uint appearance) {
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
