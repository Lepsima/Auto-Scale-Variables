using UnityEngine;
using static AutoScaleVariables.Unit;

namespace AutoScaleVariables {
public static class VMath {
	public static Force Clamp(Force force, float min, float	max) => new(Mathf.Clamp(force.value, min, max));
	
	public static Angle AngleBetween(Direction2 a, Direction2 b) => Degree(Vector2.Angle(a.value, b.value));
	public static Angle AngleBetween(Direction3 a, Direction3 b) => Degree(Vector3.Angle(a.value, b.value));
}
}