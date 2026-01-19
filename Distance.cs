using UnityEngine;
using static AutoScaleVariables.Scales;

namespace AutoScaleVariables {

public class TEST {
	public void T() {
		Length position = Meter(0);
		Velocity velocity = MeterSecond(10);
		
		// let's say Time.deltaTime is 1/50 
		
		for (int i = 0; i < 50; i++) {
			//position += velocity;
		}
		
		Debug.Log(position);
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