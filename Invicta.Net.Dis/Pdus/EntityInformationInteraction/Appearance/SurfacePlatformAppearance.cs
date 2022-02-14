﻿using Invicta.Collections.Specialized;
using Invicta.Net.SisoRef010;

using System.Reflection;
using System.Text;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction.Appearance {

	public class SurfacePlatformAppearance : IEntityAppearance {
		public AppearancePaintScheme PaintScheme {
			get => (AppearancePaintScheme) Bits[0..1];
			set => Bits[0..1] = (uint) value;
		} // 378

		public bool MobilityOrPropulsionKilled {
			get => Bits[1];
			set => Bits[1] = value;
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

		public AppearanceTrailingEffects WakeSize {
			get => (AppearanceTrailingEffects) Bits[7..9];
			set => Bits[7..9] = (uint) value;
		} // 381

		public bool RunningLightsOn {
			get => Bits[12];
			set => Bits[12] = value;
		}

		public bool IsFlaming {
			get => Bits[15];
			set => Bits[15] = value;
		}

		public bool IsAccomodationLadderLowered {
			get => Bits[16];
			set => Bits[16] = value;
		}

		public bool IsFenceRaised {
			get => Bits[17];
			set => Bits[17] = value;
		}

		public bool IsFlagRaised {
			get => Bits[18];
			set => Bits[18] = value;
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

		public bool SpotLightsOn {
			get => Bits[28];
			set => Bits[28] = value;
		}

		public bool InteriorLightsOn {
			get => Bits[29];
			set => Bits[29] = value;
		}


		public uint Appearance {
			get => Bits.Raw;
			set => Bits.Raw = value;
		}

		private Bitfield32 Bits;


		public SurfacePlatformAppearance() {
			Bits = new();
		}

		public SurfacePlatformAppearance(uint appearance) {
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
