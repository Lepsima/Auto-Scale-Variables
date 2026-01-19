using UnityEngine;
using static AutoScaleVariables.Scales;

namespace AutoScaleVariables {

public class TEST {
	public void T() {
		Length dist = Meter(100) + KiloMeter(2);
		dist += MilliMeter(5152);
		Debug.Log(dist);
		// Dist is 2105.152 meters, the left scale is used for the result

		Angle angleToTarget = Degree(200) + Radian(5);

		Length2 position2d = Meter(new Vector2(200, 500)) + KiloMeter(new Vector2(1, 5.2f));
		Length3 position3d = Meter(new Vector3(200, 500)) + KiloMeter(new Vector3(1, 5.2f));
	}
}

/*
		
 */


public enum Unit {
	INVALID,
	Time,
	Mass,
	Angle,
	Force,
	Length,
	Velocity,
	Acceleration,
	
	Angle2,
	Force2,
	Length2,
	Velocity2,
	Acceleration2,
	
	Angle3,
	Force3,
	Length3,
	Velocity3,
	Acceleration3,
}

public static class Dimension {
	public const int
		Squared = 2,
		Cubed = 3;

	public static float Apply(float value, int dimension) {
		return dimension switch {
			Squared => value * value,
			Cubed => value * value * value,
			_ => value
		};
	}
}

/*
public enum Scale {
	Giga,
	Mega,
	Kilo,
	Hecto,
	Deca,
	_,
	Deci,
	Centi ,
	Nano,
	Micro,
}
*/
}