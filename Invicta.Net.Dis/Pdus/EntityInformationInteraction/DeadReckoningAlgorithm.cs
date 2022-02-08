namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction {

	public static class DeadReckoningAlgorithm {
		public const byte Other = 0;

		public const byte Static = 1;
		public const byte NonMovingEntity = Static;
		public const byte One = Static;

		public const byte DrmFpw = 2;
		public const byte ConstantVelocityOrLowAccelerationLinearMotionEntity = DrmFpw;
		public const byte Two = DrmFpw;

		public const byte DrmRpw = 3;
		public const byte ConstantVelocityOrLowAccelerationLinearMotionEntityWithExtrapolationOfOrientation = DrmRpw;
		public const byte Three = DrmRpw;

		public const byte DrmRvw = 4;
		public const byte HighSpeedOrManeuveringEntityWithExtrapolationOfOrientation = DrmRvw;
		public const byte Four = DrmRvw;

		public const byte DrmFvw = 5;
		public const byte HighSpeedOrManeuveringEntity = DrmFvw;
		public const byte Five = DrmFvw;

		public const byte DrmFpb = 6;
		public const byte SimilarToFpwExceptInBodyCoordinates = DrmFpb;
		public const byte Six = DrmFpb;

		public const byte DrmRpb = 7;
		public const byte SimilarToRpwExceptInBodyCoordinates = DrmRpb;
		public const byte Seven = DrmRpb;

		public const byte DrmRvb = 8;
		public const byte SimilarToRvwExceptInBodyCoordinates = DrmRvb;
		public const byte Eight = DrmRvb;

		public const byte DrmFvb = 9;
		public const byte SimilarToFvwExceptInBodyCoordinates = DrmFvb;
		public const byte Nine = DrmFvb;
	}
}
