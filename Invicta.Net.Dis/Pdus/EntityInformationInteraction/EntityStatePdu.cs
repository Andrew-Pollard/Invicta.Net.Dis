using System;
using System.Buffers.Binary;
using System.Collections.Generic;


namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction {

	public class EntityStatePdu : IDisSerializable {
		public PduHeader PduHeader { get; }
		public EntityIdentifier EntityId { get; }
		public ForceId ForceId { get; private set; }
		public byte NumberOfVariableParameterRecords { get; private set; }
		public EntityType EntityType { get; }
		public EntityType AlternateEntityType { get; }
		public LinearVelocityVector EntityLinearVelocity { get; }
		public WorldCoordinates EntityLocation { get; }
		public EulerAngles EntityOrientation { get; }
		public uint EntityAppearance { get; set; }
		public DeadReckoningParameters DeadReckoningParameters { get; }
		public EntityMarking EntityMarking { get; }
		public uint Capabilities { get; set; }
		public IList<IVariableParameter> VariableParameterRecords { get; private set; }


		public EntityStatePdu() {
			PduHeader = new();
			EntityId = new();
			ForceId = ForceId.Other;
			NumberOfVariableParameterRecords = 0;
			EntityType = new();
			AlternateEntityType = new();
			EntityLinearVelocity = new();
			EntityLocation = new();
			EntityOrientation = new();
			EntityAppearance = 0;
			DeadReckoningParameters = new();
			EntityMarking = new();
			Capabilities = 0;
			VariableParameterRecords = new List<IVariableParameter>();
		}


		public EntityStatePdu(
			PduHeader pduHeader,
			EntityIdentifier entityId,
			ForceId forceId,
			byte numberOfVariableParameterRecords,
			EntityType entityType,
			EntityType alternateEntityType,
			LinearVelocityVector entityLinearVelocity,
			WorldCoordinates entityLocation,
			EulerAngles entityOrientation,
			uint entityAppearance,
			DeadReckoningParameters deadReckoningParameters,
			EntityMarking entityMarking,
			uint capabilities,
			IList<IVariableParameter> variableParameterRecords
		) {
			PduHeader = pduHeader;
			EntityId = entityId;
			ForceId = forceId;
			NumberOfVariableParameterRecords = numberOfVariableParameterRecords;
			EntityType = entityType;
			AlternateEntityType = alternateEntityType;
			EntityLinearVelocity = entityLinearVelocity;
			EntityLocation = entityLocation;
			EntityOrientation = entityOrientation;
			EntityAppearance = entityAppearance;
			DeadReckoningParameters = deadReckoningParameters;
			EntityMarking = entityMarking;
			Capabilities = capabilities;
			VariableParameterRecords = variableParameterRecords;
		}


		public void DisSerialize(Span<byte> bytes) {
			PduHeader.DisSerialize(bytes[0..12]);
			EntityId.DisSerialize(bytes[12..18]);
			bytes[19] = (byte) ForceId;

			bytes[20] = NumberOfVariableParameterRecords;

			EntityType.DisSerialize(bytes[20..28]);
			AlternateEntityType.DisSerialize(bytes[28..36]);
			EntityLinearVelocity.DisSerialize(bytes[36..48]);
			EntityLocation.DisSerialize(bytes[48..72]);
			EntityOrientation.DisSerialize(bytes[72..84]);

			BinaryPrimitives.WriteUInt32BigEndian(bytes[84..88], EntityAppearance);

			DeadReckoningParameters.DisSerialize(bytes[88..128]);
			EntityMarking.DisSerialize(bytes[128..140]);

			BinaryPrimitives.WriteUInt32BigEndian(bytes[140..144], Capabilities);

			for (int i = 0; i < NumberOfVariableParameterRecords; i++) {
				VariableParameterRecords[i].DisSerialize(bytes[(144 + i * 16)..(160 + i * 16)]);
			}
		}


		public void DisDeserialize(ReadOnlySpan<byte> bytes) {
			PduHeader.DisDeserialize(bytes[0..12]);
			PduHeader.DisDeserialize(bytes[12..18]);
			ForceId = (ForceId) bytes[19];

			NumberOfVariableParameterRecords = bytes[20];

			EntityType.DisDeserialize(bytes[20..28]);
			EntityType.DisDeserialize(bytes[28..36]);
			EntityLinearVelocity.DisDeserialize(bytes[36..48]);
			EntityLocation.DisDeserialize(bytes[48..72]);
			EntityOrientation.DisDeserialize(bytes[72..84]);

			EntityAppearance = BinaryPrimitives.ReadUInt32BigEndian(bytes[84..88]);

			DeadReckoningParameters.DisDeserialize(bytes[88..128]);
			EntityMarking.DisDeserialize(bytes[128..140]);

			EntityAppearance = BinaryPrimitives.ReadUInt32BigEndian(bytes[140..144]);

			VariableParameterRecords = new List<IVariableParameter>(NumberOfVariableParameterRecords);
			for (int i = 0; i < NumberOfVariableParameterRecords; i++) {
				VariableParameterRecords[i].DisDeserialize(bytes[(144 + i * 16)..(160 + i * 16)]);
			}
		}
	}
}
