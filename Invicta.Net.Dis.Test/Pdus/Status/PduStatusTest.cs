using Invicta.Net.Dis.Pdus.Status;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Linq;


namespace Invicta.Net.Dis.Test.Pdus.Status {

	[TestClass]
	public class PduStatusTest {
		private PduStatus PduStatus = new PduStatus();


		[TestMethod]
		public void TransferredEntityIndicator() {
			/* Reverse so we test 0 last, rather than the posibility of the set not working
			 * but the assert still passing based on the default value in the bitfield. */
			var Values = Enum.GetValues<TransferredEntityIndicator>().Reverse();

			foreach (var Value in Values) {
				PduStatus.TransferredEntityIndicator = Value;
				Assert.AreEqual(PduStatus.TransferredEntityIndicator, Value);

				//Assert.AreEqual(PduStatus.TransferredEntityIndicator, Dis.Pdus.Status.TransferredEntityIndicator.NoDifference);
				Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.NoStatement);
				Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.NotCoupled);
				Assert.AreEqual(PduStatus.FireTypeIndicator, Dis.Pdus.Status.FireTypeIndicator.Munition);
				Assert.AreEqual(PduStatus.DetonationTypeIndicator, Dis.Pdus.Status.DetonationTypeIndicator.Munition);
				Assert.AreEqual(PduStatus.RadioAttachedIndicator, Dis.Pdus.Status.RadioAttachedIndicator.NoStatement);
				Assert.AreEqual(PduStatus.IntercomAttachedIndicator, Dis.Pdus.Status.IntercomAttachedIndicator.NoStatement);
				Assert.AreEqual(PduStatus.IFFSimulationMode, Dis.Pdus.Status.IFFSimulationMode.Regeneration);
				Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, Dis.Pdus.Status.ActiveInterrogationIndicator.NotActive);
			}
		}

		[TestMethod]
		public void LVCIndicator() {
			/* Reverse so we test 0 last, rather than the posibility of the set not working
			 * but the assert still passing based on the default value in the bitfield. */
			var Values = Enum.GetValues<LVCIndicator>().Reverse();

			foreach (var Value in Values) {
				PduStatus.LVCIndicator = Value;
				Assert.AreEqual(PduStatus.LVCIndicator, Value);

				Assert.AreEqual(PduStatus.TransferredEntityIndicator, Dis.Pdus.Status.TransferredEntityIndicator.NoDifference);
				//Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.NoStatement);
				Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.NotCoupled);
				Assert.AreEqual(PduStatus.FireTypeIndicator, Dis.Pdus.Status.FireTypeIndicator.Munition);
				Assert.AreEqual(PduStatus.DetonationTypeIndicator, Dis.Pdus.Status.DetonationTypeIndicator.Munition);
				Assert.AreEqual(PduStatus.RadioAttachedIndicator, Dis.Pdus.Status.RadioAttachedIndicator.NoStatement);
				Assert.AreEqual(PduStatus.IntercomAttachedIndicator, Dis.Pdus.Status.IntercomAttachedIndicator.NoStatement);
				Assert.AreEqual(PduStatus.IFFSimulationMode, Dis.Pdus.Status.IFFSimulationMode.Regeneration);
				Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, Dis.Pdus.Status.ActiveInterrogationIndicator.NotActive);
			}
		}

		[TestMethod]
		public void CoupledExtensionIndicator() {
			/* Reverse so we test 0 last, rather than the posibility of the set not working
			 * but the assert still passing based on the default value in the bitfield. */
			var Values = Enum.GetValues<CoupledExtensionIndicator>().Reverse();

			foreach (var Value in Values) {
				PduStatus.CoupledExtensionIndicator = Value;
				Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Value);

				Assert.AreEqual(PduStatus.TransferredEntityIndicator, Dis.Pdus.Status.TransferredEntityIndicator.NoDifference);
				Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.NoStatement);
				//Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.NotCoupled);
				Assert.AreEqual(PduStatus.FireTypeIndicator, Dis.Pdus.Status.FireTypeIndicator.Munition);
				Assert.AreEqual(PduStatus.DetonationTypeIndicator, Dis.Pdus.Status.DetonationTypeIndicator.Munition);
				Assert.AreEqual(PduStatus.RadioAttachedIndicator, Dis.Pdus.Status.RadioAttachedIndicator.NoStatement);
				Assert.AreEqual(PduStatus.IntercomAttachedIndicator, Dis.Pdus.Status.IntercomAttachedIndicator.NoStatement);
				Assert.AreEqual(PduStatus.IFFSimulationMode, Dis.Pdus.Status.IFFSimulationMode.Regeneration);
				Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, Dis.Pdus.Status.ActiveInterrogationIndicator.NotActive);
			}
		}

		[TestMethod]
		public void FireTypeIndicator() {
			/* Reverse so we test 0 last, rather than the posibility of the set not working
			 * but the assert still passing based on the default value in the bitfield. */
			var Values = Enum.GetValues<FireTypeIndicator>().Reverse();

			foreach (var Value in Values) {
				PduStatus.FireTypeIndicator = Value;
				Assert.AreEqual(PduStatus.FireTypeIndicator, Value);

				Assert.AreEqual(PduStatus.TransferredEntityIndicator, Dis.Pdus.Status.TransferredEntityIndicator.NoDifference);
				Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.NoStatement);
				Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.NotCoupled);
				//Assert.AreEqual(PduStatus.FireTypeIndicator, Dis.Pdus.Status.FireTypeIndicator.Munition);
				//Assert.AreEqual(PduStatus.DetonationTypeIndicator, Dis.Pdus.Status.DetonationTypeIndicator.Munition);
				//Assert.AreEqual(PduStatus.RadioAttachedIndicator, Dis.Pdus.Status.RadioAttachedIndicator.NoStatement);
				//Assert.AreEqual(PduStatus.IntercomAttachedIndicator, Dis.Pdus.Status.IntercomAttachedIndicator.NoStatement);
				//Assert.AreEqual(PduStatus.IFFSimulationMode, Dis.Pdus.Status.IFFSimulationMode.Regeneration);
				Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, Dis.Pdus.Status.ActiveInterrogationIndicator.NotActive);
			}
		}

		[TestMethod]
		public void DetonationTypeIndicator() {
			/* Reverse so we test 0 last, rather than the posibility of the set not working
			 * but the assert still passing based on the default value in the bitfield. */
			var Values = Enum.GetValues<DetonationTypeIndicator>().Reverse();

			foreach (var Value in Values) {
				PduStatus.DetonationTypeIndicator = Value;
				Assert.AreEqual(PduStatus.DetonationTypeIndicator, Value);

				Assert.AreEqual(PduStatus.TransferredEntityIndicator, Dis.Pdus.Status.TransferredEntityIndicator.NoDifference);
				Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.NoStatement);
				Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.NotCoupled);
				//Assert.AreEqual(PduStatus.FireTypeIndicator, Dis.Pdus.Status.FireTypeIndicator.Munition);
				//Assert.AreEqual(PduStatus.DetonationTypeIndicator, Dis.Pdus.Status.DetonationTypeIndicator.Munition);
				//Assert.AreEqual(PduStatus.RadioAttachedIndicator, Dis.Pdus.Status.RadioAttachedIndicator.NoStatement);
				//Assert.AreEqual(PduStatus.IntercomAttachedIndicator, Dis.Pdus.Status.IntercomAttachedIndicator.NoStatement);
				//Assert.AreEqual(PduStatus.IFFSimulationMode, Dis.Pdus.Status.IFFSimulationMode.Regeneration);
				//Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, Dis.Pdus.Status.ActiveInterrogationIndicator.NotActive);
			}
		}

		[TestMethod]
		public void RadioAttachedIndicator() {
			/* Reverse so we test 0 last, rather than the posibility of the set not working
			 * but the assert still passing based on the default value in the bitfield. */
			var Values = Enum.GetValues<RadioAttachedIndicator>().Reverse();

			foreach (var Value in Values) {
				PduStatus.RadioAttachedIndicator = Value;
				Assert.AreEqual(PduStatus.RadioAttachedIndicator, Value);

				Assert.AreEqual(PduStatus.TransferredEntityIndicator, Dis.Pdus.Status.TransferredEntityIndicator.NoDifference);
				Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.NoStatement);
				Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.NotCoupled);
				//Assert.AreEqual(PduStatus.FireTypeIndicator, Dis.Pdus.Status.FireTypeIndicator.Munition);
				//Assert.AreEqual(PduStatus.DetonationTypeIndicator, Dis.Pdus.Status.DetonationTypeIndicator.Munition);
				//Assert.AreEqual(PduStatus.RadioAttachedIndicator, Dis.Pdus.Status.RadioAttachedIndicator.NoStatement);
				//Assert.AreEqual(PduStatus.IntercomAttachedIndicator, Dis.Pdus.Status.IntercomAttachedIndicator.NoStatement);
				//Assert.AreEqual(PduStatus.IFFSimulationMode, Dis.Pdus.Status.IFFSimulationMode.Regeneration);
				//Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, Dis.Pdus.Status.ActiveInterrogationIndicator.NotActive);
			}
		}

		[TestMethod]
		public void IntercomAttachedIndicator() {
			/* Reverse so we test 0 last, rather than the posibility of the set not working
			 * but the assert still passing based on the default value in the bitfield. */
			var Values = Enum.GetValues<IntercomAttachedIndicator>().Reverse();

			foreach (var Value in Values) {
				PduStatus.IntercomAttachedIndicator = Value;
				Assert.AreEqual(PduStatus.IntercomAttachedIndicator, Value);

				Assert.AreEqual(PduStatus.TransferredEntityIndicator, Dis.Pdus.Status.TransferredEntityIndicator.NoDifference);
				Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.NoStatement);
				Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.NotCoupled);
				//Assert.AreEqual(PduStatus.FireTypeIndicator, Dis.Pdus.Status.FireTypeIndicator.Munition);
				//Assert.AreEqual(PduStatus.DetonationTypeIndicator, Dis.Pdus.Status.DetonationTypeIndicator.Munition);
				//Assert.AreEqual(PduStatus.RadioAttachedIndicator, Dis.Pdus.Status.RadioAttachedIndicator.NoStatement);
				//Assert.AreEqual(PduStatus.IntercomAttachedIndicator, Dis.Pdus.Status.IntercomAttachedIndicator.NoStatement);
				//Assert.AreEqual(PduStatus.IFFSimulationMode, Dis.Pdus.Status.IFFSimulationMode.Regeneration);
				//Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, Dis.Pdus.Status.ActiveInterrogationIndicator.NotActive);
			}
		}

		[TestMethod]
		public void IFFSimulationMode() {
			/* Reverse so we test 0 last, rather than the posibility of the set not working
			 * but the assert still passing based on the default value in the bitfield. */
			var Values = Enum.GetValues<IFFSimulationMode>().Reverse();

			foreach (var Value in Values) {
				PduStatus.IFFSimulationMode = Value;
				Assert.AreEqual(PduStatus.IFFSimulationMode, Value);

				Assert.AreEqual(PduStatus.TransferredEntityIndicator, Dis.Pdus.Status.TransferredEntityIndicator.NoDifference);
				Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.NoStatement);
				Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.NotCoupled);
				//Assert.AreEqual(PduStatus.FireTypeIndicator, Dis.Pdus.Status.FireTypeIndicator.Munition);
				//Assert.AreEqual(PduStatus.DetonationTypeIndicator, Dis.Pdus.Status.DetonationTypeIndicator.Munition);
				//Assert.AreEqual(PduStatus.RadioAttachedIndicator, Dis.Pdus.Status.RadioAttachedIndicator.NoStatement);
				//Assert.AreEqual(PduStatus.IntercomAttachedIndicator, Dis.Pdus.Status.IntercomAttachedIndicator.NoStatement);
				//Assert.AreEqual(PduStatus.IFFSimulationMode, Dis.Pdus.Status.IFFSimulationMode.Regeneration);
				Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, Dis.Pdus.Status.ActiveInterrogationIndicator.NotActive);
			}
		}

		[TestMethod]
		public void ActiveInterrogationIndicator() {
			/* Reverse so we test 0 last, rather than the posibility of the set not working
			 * but the assert still passing based on the default value in the bitfield. */
			var Values = Enum.GetValues<ActiveInterrogationIndicator>().Reverse();

			foreach (var Value in Values) {
				PduStatus.ActiveInterrogationIndicator = Value;
				Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, Value);

				Assert.AreEqual(PduStatus.TransferredEntityIndicator, Dis.Pdus.Status.TransferredEntityIndicator.NoDifference);
				Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.NoStatement);
				Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.NotCoupled);
				Assert.AreEqual(PduStatus.FireTypeIndicator, Dis.Pdus.Status.FireTypeIndicator.Munition);
				//Assert.AreEqual(PduStatus.DetonationTypeIndicator, Dis.Pdus.Status.DetonationTypeIndicator.Munition);
				//Assert.AreEqual(PduStatus.RadioAttachedIndicator, Dis.Pdus.Status.RadioAttachedIndicator.NoStatement);
				//Assert.AreEqual(PduStatus.IntercomAttachedIndicator, Dis.Pdus.Status.IntercomAttachedIndicator.NoStatement);
				Assert.AreEqual(PduStatus.IFFSimulationMode, Dis.Pdus.Status.IFFSimulationMode.Regeneration);
				//Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, Dis.Pdus.Status.ActiveInterrogationIndicator.NotActive);
			}
		}


		[TestMethod]
		public void SimpleConstructors() {
			PduStatus = new PduStatus();
			Assert.AreEqual(PduStatus.Status, 0);

			PduStatus = new PduStatus(123);
			Assert.AreEqual(PduStatus.Status, 123);
		}

		[TestMethod]
		public void EntityState_ElectromagneticEmission_Designator_EnvironmentalProcess_EntityStateUpdateConstructor() {
			PduStatus = new PduStatus(
				Dis.Pdus.Status.TransferredEntityIndicator.Difference,
				Dis.Pdus.Status.LVCIndicator.Constructive,
				Dis.Pdus.Status.CoupledExtensionIndicator.Coupled
			);

			Assert.AreEqual(PduStatus.TransferredEntityIndicator, Dis.Pdus.Status.TransferredEntityIndicator.Difference);
			Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.Constructive);
			Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.Coupled);

			//Assert.AreEqual(PduStatus.TransferredEntityIndicator, Dis.Pdus.Status.TransferredEntityIndicator.NoDifference);
			//Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.NoStatement);
			//Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.NotCoupled);
			Assert.AreEqual(PduStatus.FireTypeIndicator, Dis.Pdus.Status.FireTypeIndicator.Munition);
			Assert.AreEqual(PduStatus.DetonationTypeIndicator, Dis.Pdus.Status.DetonationTypeIndicator.Munition);
			Assert.AreEqual(PduStatus.RadioAttachedIndicator, Dis.Pdus.Status.RadioAttachedIndicator.NoStatement);
			Assert.AreEqual(PduStatus.IntercomAttachedIndicator, Dis.Pdus.Status.IntercomAttachedIndicator.NoStatement);
			Assert.AreEqual(PduStatus.IFFSimulationMode, Dis.Pdus.Status.IFFSimulationMode.Regeneration);
			Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, Dis.Pdus.Status.ActiveInterrogationIndicator.NotActive);
		}

		[TestMethod]
		public void FireConstructor() {
			PduStatus = new PduStatus(
				Dis.Pdus.Status.LVCIndicator.Constructive,
				Dis.Pdus.Status.CoupledExtensionIndicator.Coupled,
				Dis.Pdus.Status.FireTypeIndicator.Expendable
			);

			Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.Constructive);
			Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.Coupled);
			Assert.AreEqual(PduStatus.FireTypeIndicator, Dis.Pdus.Status.FireTypeIndicator.Expendable);

			Assert.AreEqual(PduStatus.TransferredEntityIndicator, Dis.Pdus.Status.TransferredEntityIndicator.NoDifference);
			//Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.NoStatement);
			//Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.NotCoupled);
			//Assert.AreEqual(PduStatus.FireTypeIndicator, Dis.Pdus.Status.FireTypeIndicator.Munition);
			//Assert.AreEqual(PduStatus.DetonationTypeIndicator, Dis.Pdus.Status.DetonationTypeIndicator.Munition);
			//Assert.AreEqual(PduStatus.RadioAttachedIndicator, Dis.Pdus.Status.RadioAttachedIndicator.NoStatement);
			//Assert.AreEqual(PduStatus.IntercomAttachedIndicator, Dis.Pdus.Status.IntercomAttachedIndicator.NoStatement);
			//Assert.AreEqual(PduStatus.IFFSimulationMode, Dis.Pdus.Status.IFFSimulationMode.Regeneration);
			Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, Dis.Pdus.Status.ActiveInterrogationIndicator.NotActive);
		}

		[TestMethod]
		public void DetonationConstructor() {
			PduStatus = new PduStatus(
				Dis.Pdus.Status.LVCIndicator.Constructive,
				Dis.Pdus.Status.CoupledExtensionIndicator.Coupled,
				Dis.Pdus.Status.DetonationTypeIndicator.NonMunitionExplosion
			);

			Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.Constructive);
			Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.Coupled);
			Assert.AreEqual(PduStatus.DetonationTypeIndicator, Dis.Pdus.Status.DetonationTypeIndicator.NonMunitionExplosion);

			Assert.AreEqual(PduStatus.TransferredEntityIndicator, Dis.Pdus.Status.TransferredEntityIndicator.NoDifference);
			//Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.NoStatement);
			//Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.NotCoupled);
			//Assert.AreEqual(PduStatus.FireTypeIndicator, Dis.Pdus.Status.FireTypeIndicator.Munition);
			//Assert.AreEqual(PduStatus.DetonationTypeIndicator, Dis.Pdus.Status.DetonationTypeIndicator.Munition);
			//Assert.AreEqual(PduStatus.RadioAttachedIndicator, Dis.Pdus.Status.RadioAttachedIndicator.NoStatement);
			//Assert.AreEqual(PduStatus.IntercomAttachedIndicator, Dis.Pdus.Status.IntercomAttachedIndicator.NoStatement);
			//Assert.AreEqual(PduStatus.IFFSimulationMode, Dis.Pdus.Status.IFFSimulationMode.Regeneration);
			//Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, Dis.Pdus.Status.ActiveInterrogationIndicator.NotActive);
		}

		[TestMethod]
		public void Transmitter_Signal_ReceiverConstructor() {
			PduStatus = new PduStatus(
				Dis.Pdus.Status.TransferredEntityIndicator.Difference,
				Dis.Pdus.Status.LVCIndicator.Constructive,
				Dis.Pdus.Status.CoupledExtensionIndicator.Coupled,
				Dis.Pdus.Status.RadioAttachedIndicator.Attached
			);

			Assert.AreEqual(PduStatus.TransferredEntityIndicator, Dis.Pdus.Status.TransferredEntityIndicator.Difference);
			Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.Constructive);
			Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.Coupled);
			Assert.AreEqual(PduStatus.RadioAttachedIndicator, Dis.Pdus.Status.RadioAttachedIndicator.Attached);

			//Assert.AreEqual(PduStatus.TransferredEntityIndicator, Dis.Pdus.Status.TransferredEntityIndicator.NoDifference);
			//Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.NoStatement);
			//Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.NotCoupled);
			//Assert.AreEqual(PduStatus.FireTypeIndicator, Dis.Pdus.Status.FireTypeIndicator.Munition);
			//Assert.AreEqual(PduStatus.DetonationTypeIndicator, Dis.Pdus.Status.DetonationTypeIndicator.Munition);
			//Assert.AreEqual(PduStatus.RadioAttachedIndicator, Dis.Pdus.Status.RadioAttachedIndicator.NoStatement);
			//Assert.AreEqual(PduStatus.IntercomAttachedIndicator, Dis.Pdus.Status.IntercomAttachedIndicator.NoStatement);
			//Assert.AreEqual(PduStatus.IFFSimulationMode, Dis.Pdus.Status.IFFSimulationMode.Regeneration);
			//Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, Dis.Pdus.Status.ActiveInterrogationIndicator.NotActive);
		}

		[TestMethod]
		public void IFFConstructor() {
			PduStatus = new PduStatus(
				Dis.Pdus.Status.TransferredEntityIndicator.Difference,
				Dis.Pdus.Status.LVCIndicator.Constructive,
				Dis.Pdus.Status.CoupledExtensionIndicator.Coupled,
				Dis.Pdus.Status.IFFSimulationMode.Interactive,
				Dis.Pdus.Status.ActiveInterrogationIndicator.Active
			);

			Assert.AreEqual(PduStatus.TransferredEntityIndicator, Dis.Pdus.Status.TransferredEntityIndicator.Difference);
			Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.Constructive);
			Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.Coupled);
			Assert.AreEqual(PduStatus.IFFSimulationMode, Dis.Pdus.Status.IFFSimulationMode.Interactive);
			Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, Dis.Pdus.Status.ActiveInterrogationIndicator.Active);

			//Assert.AreEqual(PduStatus.TransferredEntityIndicator, Dis.Pdus.Status.TransferredEntityIndicator.NoDifference);
			//Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.NoStatement);
			//Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.NotCoupled);
			//Assert.AreEqual(PduStatus.FireTypeIndicator, Dis.Pdus.Status.FireTypeIndicator.Munition);
			//Assert.AreEqual(PduStatus.DetonationTypeIndicator, Dis.Pdus.Status.DetonationTypeIndicator.Munition);
			//Assert.AreEqual(PduStatus.RadioAttachedIndicator, Dis.Pdus.Status.RadioAttachedIndicator.NoStatement);
			//Assert.AreEqual(PduStatus.IntercomAttachedIndicator, Dis.Pdus.Status.IntercomAttachedIndicator.NoStatement);
			//Assert.AreEqual(PduStatus.IFFSimulationMode, Dis.Pdus.Status.IFFSimulationMode.Regeneration);
			//Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, Dis.Pdus.Status.ActiveInterrogationIndicator.NotActive);
		}

		[TestMethod]
		public void IntercomSignal_IntercomControlConstructor() {
			PduStatus = new PduStatus(
				Dis.Pdus.Status.TransferredEntityIndicator.Difference,
				Dis.Pdus.Status.LVCIndicator.Constructive,
				Dis.Pdus.Status.CoupledExtensionIndicator.Coupled,
				Dis.Pdus.Status.IntercomAttachedIndicator.Attached
			);

			Assert.AreEqual(PduStatus.TransferredEntityIndicator, Dis.Pdus.Status.TransferredEntityIndicator.Difference);
			Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.Constructive);
			Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.Coupled);
			Assert.AreEqual(PduStatus.IntercomAttachedIndicator, Dis.Pdus.Status.IntercomAttachedIndicator.Attached);

			//Assert.AreEqual(PduStatus.TransferredEntityIndicator, Dis.Pdus.Status.TransferredEntityIndicator.NoDifference);
			//Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.NoStatement);
			//Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.NotCoupled);
			//Assert.AreEqual(PduStatus.FireTypeIndicator, Dis.Pdus.Status.FireTypeIndicator.Munition);
			//Assert.AreEqual(PduStatus.DetonationTypeIndicator, Dis.Pdus.Status.DetonationTypeIndicator.Munition);
			//Assert.AreEqual(PduStatus.RadioAttachedIndicator, Dis.Pdus.Status.RadioAttachedIndicator.NoStatement);
			//Assert.AreEqual(PduStatus.IntercomAttachedIndicator, Dis.Pdus.Status.IntercomAttachedIndicator.NoStatement);
			//Assert.AreEqual(PduStatus.IFFSimulationMode, Dis.Pdus.Status.IFFSimulationMode.Regeneration);
			//Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, Dis.Pdus.Status.ActiveInterrogationIndicator.NotActive);
		}

		[TestMethod]
		public void AttributeConstructor() {
			PduStatus = new PduStatus(
				Dis.Pdus.Status.LVCIndicator.Constructive
			);

			Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.Constructive);

			Assert.AreEqual(PduStatus.TransferredEntityIndicator, Dis.Pdus.Status.TransferredEntityIndicator.NoDifference);
			//Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.NoStatement);
			Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.NotCoupled);
			Assert.AreEqual(PduStatus.FireTypeIndicator, Dis.Pdus.Status.FireTypeIndicator.Munition);
			Assert.AreEqual(PduStatus.DetonationTypeIndicator, Dis.Pdus.Status.DetonationTypeIndicator.Munition);
			Assert.AreEqual(PduStatus.RadioAttachedIndicator, Dis.Pdus.Status.RadioAttachedIndicator.NoStatement);
			Assert.AreEqual(PduStatus.IntercomAttachedIndicator, Dis.Pdus.Status.IntercomAttachedIndicator.NoStatement);
			Assert.AreEqual(PduStatus.IFFSimulationMode, Dis.Pdus.Status.IFFSimulationMode.Regeneration);
			Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, Dis.Pdus.Status.ActiveInterrogationIndicator.NotActive);
		}

		[TestMethod]
		public void OtherConstructor() {
			PduStatus = new PduStatus(
				Dis.Pdus.Status.LVCIndicator.Constructive,
				Dis.Pdus.Status.CoupledExtensionIndicator.Coupled
			);

			Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.Constructive);
			Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.Coupled);

			Assert.AreEqual(PduStatus.TransferredEntityIndicator, Dis.Pdus.Status.TransferredEntityIndicator.NoDifference);
			//Assert.AreEqual(PduStatus.LVCIndicator, Dis.Pdus.Status.LVCIndicator.NoStatement);
			//Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Dis.Pdus.Status.CoupledExtensionIndicator.NotCoupled);
			Assert.AreEqual(PduStatus.FireTypeIndicator, Dis.Pdus.Status.FireTypeIndicator.Munition);
			Assert.AreEqual(PduStatus.DetonationTypeIndicator, Dis.Pdus.Status.DetonationTypeIndicator.Munition);
			Assert.AreEqual(PduStatus.RadioAttachedIndicator, Dis.Pdus.Status.RadioAttachedIndicator.NoStatement);
			Assert.AreEqual(PduStatus.IntercomAttachedIndicator, Dis.Pdus.Status.IntercomAttachedIndicator.NoStatement);
			Assert.AreEqual(PduStatus.IFFSimulationMode, Dis.Pdus.Status.IFFSimulationMode.Regeneration);
			Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, Dis.Pdus.Status.ActiveInterrogationIndicator.NotActive);
		}


		[TestMethod]
		public void DisSerialize() {
			PduStatus = new(123);

			var Span = new byte[1];
			PduStatus.DisSerialize(Span);

			Assert.AreEqual(PduStatus.Status, Span.Single());
		}


		[TestMethod]
		public void DisDeserialize() {
			PduStatus = new();

			var Span = new byte[1] { 123 };
			PduStatus.DisDeserialize(Span);

			Assert.AreEqual(PduStatus.Status, Span.Single());
		}
	}
}