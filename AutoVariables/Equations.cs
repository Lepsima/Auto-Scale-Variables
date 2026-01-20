using UnityEngine;
using static AutoScaleVariables.Scales;

namespace AutoScaleVariables {
public static class Equations {
	public static Force Drag(float drag, float vel) {
		float force = Mathf.Min(vel * vel * 0.5f * drag, vel);
		return Newton(force);
	}
	
	public static Force Drag(float drag, Velocity2 vel) {
		return Drag(drag, vel.magnitude);
	}
	
	public static Force Drag(float drag, Velocity3 vel) {
		return Drag(drag, vel.magnitude);
	}
}
}