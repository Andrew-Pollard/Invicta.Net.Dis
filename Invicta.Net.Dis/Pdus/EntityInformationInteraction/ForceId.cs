namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction {

	public enum ForceId {
		Other = 0,

		Friendly = 1,
		Opposing = 2,
		Neutral = 3,

		Friendly2 = 4,
		Opposing2 = 5,
		Neutral2 = 6,

		Friendly3 = 7,
		Opposing3 = 8,
		Neutral3 = 9,

		Friendly4 = 10,
		Opposing4 = 11,
		Neutral4 = 12,

		Friendly5 = 13,
		Opposing5 = 14,
		Neutral5 = 15,

		Friendly6 = 16,
		Opposing6 = 17,
		Neutral6 = 18,

		Friendly7 = 19,
		Opposing7 = 20,
		Neutral7 = 21,

		Friendly8 = 22,
		Opposing8 = 23,
		Neutral8 = 24,

		Friendly9 = 25,
		Opposing9 = 26,
		Neutral9 = 27,

		Friendly10 = 28,
		Opposing10 = 29,
		Neutral10 = 30,
	}


	public static class ForceIdExtensionMethods {
		public static bool IsFriendly(this ForceId forceId) {
			return ((int) forceId - 1) % 3 == 0;
		}

		public static bool IsOpposing(this ForceId forceId) {
			return ((int) forceId - 2) % 3 == 0;
		}

		public static bool IsNeutral(this ForceId forceId) {
			return (forceId != ForceId.Other) && (((int) forceId - 3) % 3 == 0);
		}
	}
}
