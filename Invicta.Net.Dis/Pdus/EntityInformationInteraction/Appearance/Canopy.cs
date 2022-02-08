namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction.Appearance {

	public enum Canopy {
		NotApplicable = 0,

		SingleCanopyOrSingleTroopDoorClosed = 1,
		FrontAndRearCanopyOrLeftAndRightTroopDoorClosed = 2,
		FrontCanopyOrLeftTroopDoorOpen = 3,
		SingleCanopyOrSingleTroopDoorOpen = 4,
		RearCanopyOrRightTroopDoorOpen = 5,
		FrontAndRearCanopyOrLeftAndRightTroopDoorOpen = 6
	}
}
