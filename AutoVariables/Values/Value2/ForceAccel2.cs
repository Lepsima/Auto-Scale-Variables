using System;
using UnityEngine;

namespace AutoScaleVariables {
[Serializable]
public class ForceAccel2 : Value2<ForceAccel> {
	public ForceAccel2(Vector2 value, float scale = 1) : base(value, scale) { }
	public ForceAccel2(Force2 force, Time time) : base(force.value / time.value) { }

	public ForceAccel2() { }

	public Force2 Force2(Time time) => new(value * time);


	public static ForceAccel2 operator +(ForceAccel2 left, ForceAccel2 right) => Add(left, right);

	public static ForceAccel2 operator -(ForceAccel2 left, ForceAccel2 right) => Sub(left, right);

	public static ForceAccel2 operator *(ForceAccel2 left, ForceAccel2 right) => Mul(left, right);

	public static ForceAccel2 operator /(ForceAccel2 left, ForceAccel2 right) => Div(left, right);
}
}