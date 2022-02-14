using Invicta.Collections.Specialized;
using Invicta.Net.SisoRef010;

using System.Reflection;
using System.Text;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction.Appearance {

	public class HumanLifeFormAppearance : IEntityAppearance {
		public AppearancePaintScheme PaintScheme {
			get => (AppearancePaintScheme) Bits[0..1];
			set => Bits[0..1] = (uint) value;
		} // 378

		public AppearanceLifeformHealth Health {
			get => (AppearanceLifeformHealth) Bits[3..5];
			set => Bits[3..5] = (uint) value;
		} // 390

		public AppearanceLifeFormComplianceStatus ComplianceStatus {
			get => (AppearanceLifeFormComplianceStatus) Bits[5..7];
			set => Bits[5..7] = (uint) value;
		} // 391

		public bool SignalSmokeInUse {
			get => Bits[11];
			set => Bits[11] = value;
		}

		public bool FlashLightsOn {
			get => Bits[12];
			set => Bits[12] = value;
		}

		public bool SignalMirrorInUse {
			get => Bits[13];
			set => Bits[13] = value;
		}

		public bool IrStrobeOn {
			get => Bits[14];
			set => Bits[14] = value;
		}

		public bool IrIlluminatorOn {
			get => Bits[15];
			set => Bits[15] = value;
		}

		public AppearanceLifeFormPosture LifeFormPosture {
			get => (AppearanceLifeFormPosture) Bits[16..19];
			set => Bits[16..19] = (uint) value;
		} // 392

		public bool IsFrozen {
			get => Bits[21];
			set => Bits[21] = value;
		}

		public bool MountedOrHoistedStatus {
			get => Bits[22];
			set => Bits[22] = value;
		}

		public AppearanceEntityOrObjectState State {
			get => (AppearanceEntityOrObjectState) Bits[23..24];
			set => Bits[23..24] = (uint) value;
		} // 386

		public AppearanceLifeFormWeaponOrImplement WeaponOrImplement1 {
			get => (AppearanceLifeFormWeaponOrImplement) Bits[24..26];
			set => Bits[24..26] = (uint) value;
		} // 393

		public AppearanceLifeFormWeaponOrImplement WeaponOrImplement2 {
			get => (AppearanceLifeFormWeaponOrImplement) Bits[26..28];
			set => Bits[26..28] = (uint) value;
		} // 393

		public AppearanceCamouflageType CamouflageType {
			get => (AppearanceCamouflageType) Bits[28..30];
			set => Bits[28..30] = (uint) value;
		} // 384

		public AppearanceConcealedPosition ConcealedStationary {
			get => (AppearanceConcealedPosition) Bits[30..31];
			set => Bits[30..31] = (uint) value;
		} // 385

		public AppearanceConcealedMovement ConcealedMovement {
			get => (AppearanceConcealedMovement) Bits[31..32];
			set => Bits[31..32] = (uint) value;
		} // 394


		public uint Appearance {
			get => Bits.Raw;
			set => Bits.Raw = value;
		}

		private Bitfield32 Bits;


		public HumanLifeFormAppearance() {
			Bits = new();
		}

		public HumanLifeFormAppearance(uint appearance) {
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
