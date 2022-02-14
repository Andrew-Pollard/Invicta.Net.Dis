using Invicta.Net.SisoRef010;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction {

	public static class ForceIDExtensionMethods {
		public static bool IsFriendly(this ForceID forceId) {
			return ((int) forceId - 1) % 3 == 0;
		}

		public static bool IsOpposing(this ForceID forceId) {
			return ((int) forceId - 2) % 3 == 0;
		}

		public static bool IsNeutral(this ForceID forceId) {
			return (forceId != ForceID.Other) && (((int) forceId - 3) % 3 == 0);
		}
	}
}
