using UnityEngine;
using static AutoScaleVariables.Scales;

namespace AutoScaleVariables {

public class TEST {
	private Mass mass;
	private Force thrust;
	
	public static void T() {
		Mass mass = KiloGram(1500);
		Force force = KiloNewton(2);

		Acceleration accel = new(force, mass);
		Velocity2 vel = MeterSecond(0, 0);
		Length2 pos = Meter(0, 0);

		// For direction a normal vector2 is used because direction doesn't have a scale
		Vector2 dir = new(0.8f, 0.2f);

		while (true) {
			vel += dir * accel;
			pos += vel;
		}
	}
}
}