using UnityEngine;
using static AutoScaleVariables.Scales;

namespace AutoScaleVariables {

public class TEST {
	public static void T() {
		Mass mass = KiloGram(1500);
		Force force = KiloNewton(2);
		
		Acceleration accel = new(force, mass);
		Velocity2 vel = MeterSecond(new Vector2(0, 0));
		Length2 pos = Meter(new Vector2(0, 0));
		
		// For direction a normal vector2 is used because direction doesn't have a scale
		Vector2 dir = new(0.2f, 0.8f);
		
		while (true) {
			vel += dir * accel;
			pos += vel;
		}
	}
}


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