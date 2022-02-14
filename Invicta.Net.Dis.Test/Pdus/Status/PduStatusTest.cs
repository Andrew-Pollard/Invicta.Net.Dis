using Invicta.Net.Dis.Pdus.Status;
using Invicta.Net.SisoRef010;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Linq;


namespace Invicta.Net.Dis.Test.Pdus.Status {

	[TestClass]
	public class PduStatusTest {
		private PduStatus PduStatus = new();


		[TestMethod]
		public void TransferredEntityIndicator() {
			/* Reverse so we test 0 last, rather than the posibility of the set not working
			 * but the assert still passing based on the default value in the bitfield. */
			var Values = Enum.GetValues<DISPDUStatusTransferredEntityIndicatorTEI>().Reverse();

			foreach (var Value in Values) {
				PduStatus.TransferredEntityIndicator = Value;
				Assert.AreEqual(PduStatus.TransferredEntityIndicator, Value);

				//Assert.AreEqual(PduStatus.TransferredEntityIndicator, DISPDUStatusTransferredEntityIndicatorTEI.NoDifference);
				Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.NoStatement);
				Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.NotCoupled);
				Assert.AreEqual(PduStatus.FireTypeIndicator, DISPDUStatusFireTypeIndicatorFTI.Munition);
				Assert.AreEqual(PduStatus.DetonationTypeIndicator, DISPDUStatusDetonationTypeIndicatorDTI.Munition);
				Assert.AreEqual(PduStatus.RadioAttachedIndicator, DISPDUStatusRadioAttachedIndicatorRAI.NoStatement);
				Assert.AreEqual(PduStatus.IntercomAttachedIndicator, DISPDUStatusIntercomAttachedIndicatorIAI.NoStatement);
				Assert.AreEqual(PduStatus.IFFSimulationMode, DISPDUStatusIFFSimulationModeISM.Regeneration);
				Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, DISPDUStatusActiveInterrogationIndicatorAII.NotActive);
			}
		}

		[TestMethod]
		public void LVCIndicator() {
			/* Reverse so we test 0 last, rather than the posibility of the set not working
			 * but the assert still passing based on the default value in the bitfield. */
			var Values = Enum.GetValues<DISPDUStatusLVCIndicatorLVC>().Reverse();

			foreach (var Value in Values) {
				PduStatus.LVCIndicator = Value;
				Assert.AreEqual(PduStatus.LVCIndicator, Value);

				Assert.AreEqual(PduStatus.TransferredEntityIndicator, DISPDUStatusTransferredEntityIndicatorTEI.NoDifference);
				//Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.NoStatement);
				Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.NotCoupled);
				Assert.AreEqual(PduStatus.FireTypeIndicator, DISPDUStatusFireTypeIndicatorFTI.Munition);
				Assert.AreEqual(PduStatus.DetonationTypeIndicator, DISPDUStatusDetonationTypeIndicatorDTI.Munition);
				Assert.AreEqual(PduStatus.RadioAttachedIndicator, DISPDUStatusRadioAttachedIndicatorRAI.NoStatement);
				Assert.AreEqual(PduStatus.IntercomAttachedIndicator, DISPDUStatusIntercomAttachedIndicatorIAI.NoStatement);
				Assert.AreEqual(PduStatus.IFFSimulationMode, DISPDUStatusIFFSimulationModeISM.Regeneration);
				Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, DISPDUStatusActiveInterrogationIndicatorAII.NotActive);
			}
		}

		[TestMethod]
		public void CoupledExtensionIndicator() {
			/* Reverse so we test 0 last, rather than the posibility of the set not working
			 * but the assert still passing based on the default value in the bitfield. */
			var Values = Enum.GetValues<DISPDUStatusCoupledExtensionIndicatorCEI>().Reverse();

			foreach (var Value in Values) {
				PduStatus.CoupledExtensionIndicator = Value;
				Assert.AreEqual(PduStatus.CoupledExtensionIndicator, Value);

				Assert.AreEqual(PduStatus.TransferredEntityIndicator, DISPDUStatusTransferredEntityIndicatorTEI.NoDifference);
				Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.NoStatement);
				//Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.NotCoupled);
				Assert.AreEqual(PduStatus.FireTypeIndicator, DISPDUStatusFireTypeIndicatorFTI.Munition);
				Assert.AreEqual(PduStatus.DetonationTypeIndicator, DISPDUStatusDetonationTypeIndicatorDTI.Munition);
				Assert.AreEqual(PduStatus.RadioAttachedIndicator, DISPDUStatusRadioAttachedIndicatorRAI.NoStatement);
				Assert.AreEqual(PduStatus.IntercomAttachedIndicator, DISPDUStatusIntercomAttachedIndicatorIAI.NoStatement);
				Assert.AreEqual(PduStatus.IFFSimulationMode, DISPDUStatusIFFSimulationModeISM.Regeneration);
				Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, DISPDUStatusActiveInterrogationIndicatorAII.NotActive);
			}
		}

		[TestMethod]
		public void FireTypeIndicator() {
			/* Reverse so we test 0 last, rather than the posibility of the set not working
			 * but the assert still passing based on the default value in the bitfield. */
			var Values = Enum.GetValues<DISPDUStatusFireTypeIndicatorFTI>().Reverse();

			foreach (var Value in Values) {
				PduStatus.FireTypeIndicator = Value;
				Assert.AreEqual(PduStatus.FireTypeIndicator, Value);

				Assert.AreEqual(PduStatus.TransferredEntityIndicator, DISPDUStatusTransferredEntityIndicatorTEI.NoDifference);
				Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.NoStatement);
				Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.NotCoupled);
				//Assert.AreEqual(PduStatus.FireTypeIndicator, DISPDUStatusFireTypeIndicatorFTI.Munition);
				//Assert.AreEqual(PduStatus.DetonationTypeIndicator, DISPDUStatusDetonationTypeIndicatorDTI.Munition);
				//Assert.AreEqual(PduStatus.RadioAttachedIndicator, DISPDUStatusRadioAttachedIndicatorRAI.NoStatement);
				//Assert.AreEqual(PduStatus.IntercomAttachedIndicator, DISPDUStatusIntercomAttachedIndicatorIAI.NoStatement);
				//Assert.AreEqual(PduStatus.IFFSimulationMode, DISPDUStatusIFFSimulationModeISM.Regeneration);
				Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, DISPDUStatusActiveInterrogationIndicatorAII.NotActive);
			}
		}

		[TestMethod]
		public void DetonationTypeIndicator() {
			/* Reverse so we test 0 last, rather than the posibility of the set not working
			 * but the assert still passing based on the default value in the bitfield. */
			var Values = Enum.GetValues<DISPDUStatusDetonationTypeIndicatorDTI>().Reverse();

			foreach (var Value in Values) {
				PduStatus.DetonationTypeIndicator = Value;
				Assert.AreEqual(PduStatus.DetonationTypeIndicator, Value);

				Assert.AreEqual(PduStatus.TransferredEntityIndicator, DISPDUStatusTransferredEntityIndicatorTEI.NoDifference);
				Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.NoStatement);
				Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.NotCoupled);
				//Assert.AreEqual(PduStatus.FireTypeIndicator, DISPDUStatusFireTypeIndicatorFTI.Munition);
				//Assert.AreEqual(PduStatus.DetonationTypeIndicator, DISPDUStatusDetonationTypeIndicatorDTI.Munition);
				//Assert.AreEqual(PduStatus.RadioAttachedIndicator, DISPDUStatusRadioAttachedIndicatorRAI.NoStatement);
				//Assert.AreEqual(PduStatus.IntercomAttachedIndicator, DISPDUStatusIntercomAttachedIndicatorIAI.NoStatement);
				//Assert.AreEqual(PduStatus.IFFSimulationMode, DISPDUStatusIFFSimulationModeISM.Regeneration);
				//Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, DISPDUStatusActiveInterrogationIndicatorAII.NotActive);
			}
		}

		[TestMethod]
		public void RadioAttachedIndicator() {
			/* Reverse so we test 0 last, rather than the posibility of the set not working
			 * but the assert still passing based on the default value in the bitfield. */
			var Values = Enum.GetValues<DISPDUStatusRadioAttachedIndicatorRAI>().Reverse();

			foreach (var Value in Values) {
				PduStatus.RadioAttachedIndicator = Value;
				Assert.AreEqual(PduStatus.RadioAttachedIndicator, Value);

				Assert.AreEqual(PduStatus.TransferredEntityIndicator, DISPDUStatusTransferredEntityIndicatorTEI.NoDifference);
				Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.NoStatement);
				Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.NotCoupled);
				//Assert.AreEqual(PduStatus.FireTypeIndicator, DISPDUStatusFireTypeIndicatorFTI.Munition);
				//Assert.AreEqual(PduStatus.DetonationTypeIndicator, DISPDUStatusDetonationTypeIndicatorDTI.Munition);
				//Assert.AreEqual(PduStatus.RadioAttachedIndicator, DISPDUStatusRadioAttachedIndicatorRAI.NoStatement);
				//Assert.AreEqual(PduStatus.IntercomAttachedIndicator, DISPDUStatusIntercomAttachedIndicatorIAI.NoStatement);
				//Assert.AreEqual(PduStatus.IFFSimulationMode, DISPDUStatusIFFSimulationModeISM.Regeneration);
				//Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, DISPDUStatusActiveInterrogationIndicatorAII.NotActive);
			}
		}

		[TestMethod]
		public void IntercomAttachedIndicator() {
			/* Reverse so we test 0 last, rather than the posibility of the set not working
			 * but the assert still passing based on the default value in the bitfield. */
			var Values = Enum.GetValues<DISPDUStatusIntercomAttachedIndicatorIAI>().Reverse();

			foreach (var Value in Values) {
				PduStatus.IntercomAttachedIndicator = Value;
				Assert.AreEqual(PduStatus.IntercomAttachedIndicator, Value);

				Assert.AreEqual(PduStatus.TransferredEntityIndicator, DISPDUStatusTransferredEntityIndicatorTEI.NoDifference);
				Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.NoStatement);
				Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.NotCoupled);
				//Assert.AreEqual(PduStatus.FireTypeIndicator, DISPDUStatusFireTypeIndicatorFTI.Munition);
				//Assert.AreEqual(PduStatus.DetonationTypeIndicator, DISPDUStatusDetonationTypeIndicatorDTI.Munition);
				//Assert.AreEqual(PduStatus.RadioAttachedIndicator, DISPDUStatusRadioAttachedIndicatorRAI.NoStatement);
				//Assert.AreEqual(PduStatus.IntercomAttachedIndicator, DISPDUStatusIntercomAttachedIndicatorIAI.NoStatement);
				//Assert.AreEqual(PduStatus.IFFSimulationMode, DISPDUStatusIFFSimulationModeISM.Regeneration);
				//Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, DISPDUStatusActiveInterrogationIndicatorAII.NotActive);
			}
		}

		[TestMethod]
		public void IFFSimulationMode() {
			/* Reverse so we test 0 last, rather than the posibility of the set not working
			 * but the assert still passing based on the default value in the bitfield. */
			var Values = Enum.GetValues<DISPDUStatusIFFSimulationModeISM>().Reverse();

			foreach (var Value in Values) {
				PduStatus.IFFSimulationMode = Value;
				Assert.AreEqual(PduStatus.IFFSimulationMode, Value);

				Assert.AreEqual(PduStatus.TransferredEntityIndicator, DISPDUStatusTransferredEntityIndicatorTEI.NoDifference);
				Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.NoStatement);
				Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.NotCoupled);
				//Assert.AreEqual(PduStatus.FireTypeIndicator, DISPDUStatusFireTypeIndicatorFTI.Munition);
				//Assert.AreEqual(PduStatus.DetonationTypeIndicator, DISPDUStatusDetonationTypeIndicatorDTI.Munition);
				//Assert.AreEqual(PduStatus.RadioAttachedIndicator, DISPDUStatusRadioAttachedIndicatorRAI.NoStatement);
				//Assert.AreEqual(PduStatus.IntercomAttachedIndicator, DISPDUStatusIntercomAttachedIndicatorIAI.NoStatement);
				//Assert.AreEqual(PduStatus.IFFSimulationMode, DISPDUStatusIFFSimulationModeISM.Regeneration);
				Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, DISPDUStatusActiveInterrogationIndicatorAII.NotActive);
			}
		}

		[TestMethod]
		public void ActiveInterrogationIndicator() {
			/* Reverse so we test 0 last, rather than the posibility of the set not working
			 * but the assert still passing based on the default value in the bitfield. */
			var Values = Enum.GetValues<DISPDUStatusActiveInterrogationIndicatorAII>().Reverse();

			foreach (var Value in Values) {
				PduStatus.ActiveInterrogationIndicator = Value;
				Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, Value);

				Assert.AreEqual(PduStatus.TransferredEntityIndicator, DISPDUStatusTransferredEntityIndicatorTEI.NoDifference);
				Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.NoStatement);
				Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.NotCoupled);
				Assert.AreEqual(PduStatus.FireTypeIndicator, DISPDUStatusFireTypeIndicatorFTI.Munition);
				//Assert.AreEqual(PduStatus.DetonationTypeIndicator, DISPDUStatusDetonationTypeIndicatorDTI.Munition);
				//Assert.AreEqual(PduStatus.RadioAttachedIndicator, DISPDUStatusRadioAttachedIndicatorRAI.NoStatement);
				//Assert.AreEqual(PduStatus.IntercomAttachedIndicator, DISPDUStatusIntercomAttachedIndicatorIAI.NoStatement);
				Assert.AreEqual(PduStatus.IFFSimulationMode, DISPDUStatusIFFSimulationModeISM.Regeneration);
				//Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, DISPDUStatusActiveInterrogationIndicatorAII.NotActive);
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
				DISPDUStatusTransferredEntityIndicatorTEI.Difference,
				DISPDUStatusLVCIndicatorLVC.Constructive,
				DISPDUStatusCoupledExtensionIndicatorCEI.Coupled
			);

			Assert.AreEqual(PduStatus.TransferredEntityIndicator, DISPDUStatusTransferredEntityIndicatorTEI.Difference);
			Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.Constructive);
			Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.Coupled);

			//Assert.AreEqual(PduStatus.TransferredEntityIndicator, DISPDUStatusTransferredEntityIndicatorTEI.NoDifference);
			//Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.NoStatement);
			//Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.NotCoupled);
			Assert.AreEqual(PduStatus.FireTypeIndicator, DISPDUStatusFireTypeIndicatorFTI.Munition);
			Assert.AreEqual(PduStatus.DetonationTypeIndicator, DISPDUStatusDetonationTypeIndicatorDTI.Munition);
			Assert.AreEqual(PduStatus.RadioAttachedIndicator, DISPDUStatusRadioAttachedIndicatorRAI.NoStatement);
			Assert.AreEqual(PduStatus.IntercomAttachedIndicator, DISPDUStatusIntercomAttachedIndicatorIAI.NoStatement);
			Assert.AreEqual(PduStatus.IFFSimulationMode, DISPDUStatusIFFSimulationModeISM.Regeneration);
			Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, DISPDUStatusActiveInterrogationIndicatorAII.NotActive);
		}

		[TestMethod]
		public void FireConstructor() {
			PduStatus = new PduStatus(
				DISPDUStatusLVCIndicatorLVC.Constructive,
				DISPDUStatusCoupledExtensionIndicatorCEI.Coupled,
				DISPDUStatusFireTypeIndicatorFTI.Expendable
			);

			Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.Constructive);
			Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.Coupled);
			Assert.AreEqual(PduStatus.FireTypeIndicator, DISPDUStatusFireTypeIndicatorFTI.Expendable);

			Assert.AreEqual(PduStatus.TransferredEntityIndicator, DISPDUStatusTransferredEntityIndicatorTEI.NoDifference);
			//Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.NoStatement);
			//Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.NotCoupled);
			//Assert.AreEqual(PduStatus.FireTypeIndicator, DISPDUStatusFireTypeIndicatorFTI.Munition);
			//Assert.AreEqual(PduStatus.DetonationTypeIndicator, DISPDUStatusDetonationTypeIndicatorDTI.Munition);
			//Assert.AreEqual(PduStatus.RadioAttachedIndicator, DISPDUStatusRadioAttachedIndicatorRAI.NoStatement);
			//Assert.AreEqual(PduStatus.IntercomAttachedIndicator, DISPDUStatusIntercomAttachedIndicatorIAI.NoStatement);
			//Assert.AreEqual(PduStatus.IFFSimulationMode, DISPDUStatusIFFSimulationModeISM.Regeneration);
			Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, DISPDUStatusActiveInterrogationIndicatorAII.NotActive);
		}

		[TestMethod]
		public void DetonationConstructor() {
			PduStatus = new PduStatus(
				DISPDUStatusLVCIndicatorLVC.Constructive,
				DISPDUStatusCoupledExtensionIndicatorCEI.Coupled,
				DISPDUStatusDetonationTypeIndicatorDTI.NonMunitionExplosion
			);

			Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.Constructive);
			Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.Coupled);
			Assert.AreEqual(PduStatus.DetonationTypeIndicator, DISPDUStatusDetonationTypeIndicatorDTI.NonMunitionExplosion);

			Assert.AreEqual(PduStatus.TransferredEntityIndicator, DISPDUStatusTransferredEntityIndicatorTEI.NoDifference);
			//Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.NoStatement);
			//Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.NotCoupled);
			//Assert.AreEqual(PduStatus.FireTypeIndicator, DISPDUStatusFireTypeIndicatorFTI.Munition);
			//Assert.AreEqual(PduStatus.DetonationTypeIndicator, DISPDUStatusDetonationTypeIndicatorDTI.Munition);
			//Assert.AreEqual(PduStatus.RadioAttachedIndicator, DISPDUStatusRadioAttachedIndicatorRAI.NoStatement);
			//Assert.AreEqual(PduStatus.IntercomAttachedIndicator, DISPDUStatusIntercomAttachedIndicatorIAI.NoStatement);
			//Assert.AreEqual(PduStatus.IFFSimulationMode, DISPDUStatusIFFSimulationModeISM.Regeneration);
			//Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, DISPDUStatusActiveInterrogationIndicatorAII.NotActive);
		}

		[TestMethod]
		public void Transmitter_Signal_ReceiverConstructor() {
			PduStatus = new PduStatus(
				DISPDUStatusTransferredEntityIndicatorTEI.Difference,
				DISPDUStatusLVCIndicatorLVC.Constructive,
				DISPDUStatusCoupledExtensionIndicatorCEI.Coupled,
				DISPDUStatusRadioAttachedIndicatorRAI.Attached
			);

			Assert.AreEqual(PduStatus.TransferredEntityIndicator, DISPDUStatusTransferredEntityIndicatorTEI.Difference);
			Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.Constructive);
			Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.Coupled);
			Assert.AreEqual(PduStatus.RadioAttachedIndicator, DISPDUStatusRadioAttachedIndicatorRAI.Attached);

			//Assert.AreEqual(PduStatus.TransferredEntityIndicator, DISPDUStatusTransferredEntityIndicatorTEI.NoDifference);
			//Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.NoStatement);
			//Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.NotCoupled);
			//Assert.AreEqual(PduStatus.FireTypeIndicator, DISPDUStatusFireTypeIndicatorFTI.Munition);
			//Assert.AreEqual(PduStatus.DetonationTypeIndicator, DISPDUStatusDetonationTypeIndicatorDTI.Munition);
			//Assert.AreEqual(PduStatus.RadioAttachedIndicator, DISPDUStatusRadioAttachedIndicatorRAI.NoStatement);
			//Assert.AreEqual(PduStatus.IntercomAttachedIndicator, DISPDUStatusIntercomAttachedIndicatorIAI.NoStatement);
			//Assert.AreEqual(PduStatus.IFFSimulationMode, DISPDUStatusIFFSimulationModeISM.Regeneration);
			//Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, DISPDUStatusActiveInterrogationIndicatorAII.NotActive);
		}

		[TestMethod]
		public void IFFConstructor() {
			PduStatus = new PduStatus(
				DISPDUStatusTransferredEntityIndicatorTEI.Difference,
				DISPDUStatusLVCIndicatorLVC.Constructive,
				DISPDUStatusCoupledExtensionIndicatorCEI.Coupled,
				DISPDUStatusIFFSimulationModeISM.Interactive,
				DISPDUStatusActiveInterrogationIndicatorAII.Active
			);

			Assert.AreEqual(PduStatus.TransferredEntityIndicator, DISPDUStatusTransferredEntityIndicatorTEI.Difference);
			Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.Constructive);
			Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.Coupled);
			Assert.AreEqual(PduStatus.IFFSimulationMode, DISPDUStatusIFFSimulationModeISM.Interactive);
			Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, DISPDUStatusActiveInterrogationIndicatorAII.Active);

			//Assert.AreEqual(PduStatus.TransferredEntityIndicator, DISPDUStatusTransferredEntityIndicatorTEI.NoDifference);
			//Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.NoStatement);
			//Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.NotCoupled);
			//Assert.AreEqual(PduStatus.FireTypeIndicator, DISPDUStatusFireTypeIndicatorFTI.Munition);
			//Assert.AreEqual(PduStatus.DetonationTypeIndicator, DISPDUStatusDetonationTypeIndicatorDTI.Munition);
			//Assert.AreEqual(PduStatus.RadioAttachedIndicator, DISPDUStatusRadioAttachedIndicatorRAI.NoStatement);
			//Assert.AreEqual(PduStatus.IntercomAttachedIndicator, DISPDUStatusIntercomAttachedIndicatorIAI.NoStatement);
			//Assert.AreEqual(PduStatus.IFFSimulationMode, DISPDUStatusIFFSimulationModeISM.Regeneration);
			//Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, DISPDUStatusActiveInterrogationIndicatorAII.NotActive);
		}

		[TestMethod]
		public void IntercomSignal_IntercomControlConstructor() {
			PduStatus = new PduStatus(
				DISPDUStatusTransferredEntityIndicatorTEI.Difference,
				DISPDUStatusLVCIndicatorLVC.Constructive,
				DISPDUStatusCoupledExtensionIndicatorCEI.Coupled,
				DISPDUStatusIntercomAttachedIndicatorIAI.Attached
			);

			Assert.AreEqual(PduStatus.TransferredEntityIndicator, DISPDUStatusTransferredEntityIndicatorTEI.Difference);
			Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.Constructive);
			Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.Coupled);
			Assert.AreEqual(PduStatus.IntercomAttachedIndicator, DISPDUStatusIntercomAttachedIndicatorIAI.Attached);

			//Assert.AreEqual(PduStatus.TransferredEntityIndicator, DISPDUStatusTransferredEntityIndicatorTEI.NoDifference);
			//Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.NoStatement);
			//Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.NotCoupled);
			//Assert.AreEqual(PduStatus.FireTypeIndicator, DISPDUStatusFireTypeIndicatorFTI.Munition);
			//Assert.AreEqual(PduStatus.DetonationTypeIndicator, DISPDUStatusDetonationTypeIndicatorDTI.Munition);
			//Assert.AreEqual(PduStatus.RadioAttachedIndicator, DISPDUStatusRadioAttachedIndicatorRAI.NoStatement);
			//Assert.AreEqual(PduStatus.IntercomAttachedIndicator, DISPDUStatusIntercomAttachedIndicatorIAI.NoStatement);
			//Assert.AreEqual(PduStatus.IFFSimulationMode, DISPDUStatusIFFSimulationModeISM.Regeneration);
			//Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, DISPDUStatusActiveInterrogationIndicatorAII.NotActive);
		}

		[TestMethod]
		public void AttributeConstructor() {
			PduStatus = new PduStatus(
				DISPDUStatusLVCIndicatorLVC.Constructive
			);

			Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.Constructive);

			Assert.AreEqual(PduStatus.TransferredEntityIndicator, DISPDUStatusTransferredEntityIndicatorTEI.NoDifference);
			//Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.NoStatement);
			Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.NotCoupled);
			Assert.AreEqual(PduStatus.FireTypeIndicator, DISPDUStatusFireTypeIndicatorFTI.Munition);
			Assert.AreEqual(PduStatus.DetonationTypeIndicator, DISPDUStatusDetonationTypeIndicatorDTI.Munition);
			Assert.AreEqual(PduStatus.RadioAttachedIndicator, DISPDUStatusRadioAttachedIndicatorRAI.NoStatement);
			Assert.AreEqual(PduStatus.IntercomAttachedIndicator, DISPDUStatusIntercomAttachedIndicatorIAI.NoStatement);
			Assert.AreEqual(PduStatus.IFFSimulationMode, DISPDUStatusIFFSimulationModeISM.Regeneration);
			Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, DISPDUStatusActiveInterrogationIndicatorAII.NotActive);
		}

		[TestMethod]
		public void OtherConstructor() {
			PduStatus = new PduStatus(
				DISPDUStatusLVCIndicatorLVC.Constructive,
				DISPDUStatusCoupledExtensionIndicatorCEI.Coupled
			);

			Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.Constructive);
			Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.Coupled);

			Assert.AreEqual(PduStatus.TransferredEntityIndicator, DISPDUStatusTransferredEntityIndicatorTEI.NoDifference);
			//Assert.AreEqual(PduStatus.LVCIndicator, DISPDUStatusLVCIndicatorLVC.NoStatement);
			//Assert.AreEqual(PduStatus.CoupledExtensionIndicator, DISPDUStatusCoupledExtensionIndicatorCEI.NotCoupled);
			Assert.AreEqual(PduStatus.FireTypeIndicator, DISPDUStatusFireTypeIndicatorFTI.Munition);
			Assert.AreEqual(PduStatus.DetonationTypeIndicator, DISPDUStatusDetonationTypeIndicatorDTI.Munition);
			Assert.AreEqual(PduStatus.RadioAttachedIndicator, DISPDUStatusRadioAttachedIndicatorRAI.NoStatement);
			Assert.AreEqual(PduStatus.IntercomAttachedIndicator, DISPDUStatusIntercomAttachedIndicatorIAI.NoStatement);
			Assert.AreEqual(PduStatus.IFFSimulationMode, DISPDUStatusIFFSimulationModeISM.Regeneration);
			Assert.AreEqual(PduStatus.ActiveInterrogationIndicator, DISPDUStatusActiveInterrogationIndicatorAII.NotActive);
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