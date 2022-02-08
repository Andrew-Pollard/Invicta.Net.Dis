using Invicta.Collections.Specialized;

using System.Linq;
using System.Reflection;
using System.Text;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction.Appearance {

	public class SensorOrEmitterAppearance : IEntityAppearance {
		public PaintScheme PaintScheme {
			get => (PaintScheme) Bits[0..1];
			set => Bits[0..1] = (uint) value;
		} // 378

		public bool MobilityKilled {
			get => Bits[1];
			set => Bits[1] = value;
		}

		public bool MissionKilled {
			get => Bits[2];
			set => Bits[2] = value;
		}

		public Damage Damage {
			get => (Damage) Bits[3..5];
			set => Bits[3..5] = (uint) value;
		} // 379

		public bool IsSmokeEmanating {
			get => Bits[5];
			set => Bits[5] = value;
		}

		public bool IsEngineEmittingSmoke {
			get => Bits[6];
			set => Bits[6] = value;
		}

		public TrailingEffects TrailingEffects {
			get => (TrailingEffects) Bits[7..9];
			set => Bits[7..9] = (uint) value;
		} // 381

		public bool LightsOn {
			get => Bits[12];
			set => Bits[12] = value;
		}

		public bool IsFlaming {
			get => Bits[15];
			set => Bits[15] = value;
		}

		public bool AntennaRaised {
			get => Bits[16];
			set => Bits[16] = value;
		}

		public CamouflageType CamouflageType {
			get => (CamouflageType) Bits[17..19];
			set => Bits[17..19] = (uint) value;
		} // 384

		public ConcealedPosition ConcealedPosition {
			get => (ConcealedPosition) Bits[19..20];
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

		public EntityOrObjectState State {
			get => (EntityOrObjectState) Bits[23..24];
			set => Bits[23..24] = (uint) value;
		} // 386

		public bool TentExtended {
			get => Bits[24];
			set => Bits[24] = value;
		}

		public bool BlackoutLightsOn {
			get => Bits[26];
			set => Bits[26] = value;
		}

		public bool InteriorLightsForwardOn {
			get => Bits[29];
			set => Bits[29] = value;
		}


		public uint Appearance {
			get => Bits.Raw;
			set => Bits.Raw = value;
		}

		private Bitfield32 Bits;


		public SensorOrEmitterAppearance() {
			Bits = new();
		}

		public SensorOrEmitterAppearance(uint appearance) {
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
