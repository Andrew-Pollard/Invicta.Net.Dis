using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invicta.Net.Dis.Pdus.EntityInformationInteraction.VariableParameters {

	public enum ArticulatedPartTypeClass {
		NotSpecified = 0,

		Rudder = 1024,
		LeftFlap = 1056,
		RightFlap = 1088,
		LeftAileron = 1120,
		RightAileron = 1152,
		HelicopterMainRotor = 1184,
		HelicopterTailRotor = 1216,
		OtherAircraftControlSurfacesDefinedAsNeeded = 1248,
		PropellerNumber1 = 1280,
		PropellerNumber2 = 1312,
		PropellerNumber3 = 1344,
		PropellerNumber4 = 1376,
		LeftStabilator = 1408,
		StabilatorNumber1 = 1408,
		RightStabilator = 1440,
		StabilatorNumber2 = 1440,
		LeftRuddervator = 1472,
		RuddervatorNumber1 = 1472,
		RightRuddervator = 1504,
		RuddervatorNumber2 = 1504,
		LeftLeadingEdgeFlapOrSlat = 1536,
		RightLeadingEdgeFlapOrSlat = 1568,
		LeftElevator = 1600,
		RightElevator = 1632,
		LeftCanard = 1664,
		RightCanard = 1696,
		LeftElevonInner = 1728,
		RightElevonInner = 1760,
		LeftElevonMiddle = 1792,
		RightElevonMiddle = 1824,
		LeftElevonOuter = 1856,
		RightElevonOuter = 1888,
		AircraftCanopy = 1920,
		Periscope = 2048,
		GenericAntenna = 2080,
		Snorkel = 2112,
		OtherExtendiblePartsDefinedAsNeeded = 2144,
		LeftDivePlaneSail = 2176,
		RightDivePlaneSail = 2208,
		LeftDivePlaneBow = 2240,
		RightDivePlaneBow = 2272,

	}
}
