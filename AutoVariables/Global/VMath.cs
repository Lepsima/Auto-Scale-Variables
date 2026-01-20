using UnityEngine;
using static AutoScaleVariables.Unit;

namespace AutoScaleVariables {
public static class VMath {
	public static Force Clamp(Force force, float min, float	max) => new(Mathf.Clamp(force.value, min, max));
	
	public static Angle AngleBetween(Value3 a, Value3 b) => Degree(Vector3.Angle(a.value, b.value));
}
}