using Invicta.Collections.Specialized;

using System.Linq;
using System.Reflection;
using System.Text;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction.Appearance {

	public class SupplyAppearance : IEntityAppearance {
		public PaintScheme PaintScheme {
			get => (PaintScheme) Bits[0..1];
			set => Bits[0..1] = (uint) value;
		} // 378

		public Damage Damage {
			get => (Damage) Bits[3..5];
			set => Bits[3..5] = (uint) value;
		} // 379

		public Parachute ParacuteStatus {
			get => (Parachute) Bits[7..9];
			set => Bits[7..9] = (uint) value;
		} // 401

		public bool IsFlaming {
			get => Bits[15];
			set => Bits[15] = value;
		}

		public bool IsFrozen {
			get => Bits[21];
			set => Bits[21] = value;
		}

		public EntityOrObjectState State {
			get => (EntityOrObjectState) Bits[23..24];
			set => Bits[23..24] = (uint) value;
		} // 386

		public SupplyDeployed DeployedStatus {
			get => (SupplyDeployed) Bits[24..26];
			set => Bits[24..26] = (uint) value;
		} // 399

		public bool MaskedOrCloaked {
			get => Bits[31];
			set => Bits[31] = value;
		}

		public uint Appearance {
			get => Bits.Raw;
			set => Bits.Raw = value;
		}

		private Bitfield32 Bits;


		public SupplyAppearance() {
			Bits = new();
		}

		public SupplyAppearance(uint appearance) {
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
