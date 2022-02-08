using System;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction {

	public class DeadReckoningParameters : IDisSerializable {
		public interface IOtherParameters : IDisSerializable { }


		public const int Size = 40;


		public byte DeadReckoningAlgorithm { get; private set; }
		public IOtherParameters OtherParameters { get; }

		public LinearAccelerationVector EntityLinearAcceleration { get; }
		public AngularVelocityVector EntityAngularVelocity { get; }


		public void DisSerialize(Span<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			bytes[0] = DeadReckoningAlgorithm;
			OtherParameters.DisSerialize(bytes[1..16]);
			EntityLinearAcceleration.DisSerialize(bytes[16..28]);
			EntityAngularVelocity.DisSerialize(bytes[28..40]);
		}


		public void DisDeserialize(ReadOnlySpan<byte> bytes) {
			if (bytes.Length != Size)
				throw new ArgumentException(nameof(bytes));

			DeadReckoningAlgorithm = bytes[0];
			OtherParameters.DisDeserialize(bytes[1..16]);
			EntityLinearAcceleration.DisDeserialize(bytes[16..28]);
			EntityAngularVelocity.DisDeserialize(bytes[28..40]);
		}
	}
}
