using System;
using UnityEngine;

namespace AutoScaleVariables {
[Serializable]
public class ForceAccel3 : Value3<ForceAccel> {
	public ForceAccel3(Vector3 value, float scale = 1) : base(value, scale) { }
	public ForceAccel3(Force3 force, Time time) : base(force.value / time.value) { }

	public ForceAccel3() { }

	public Force3 Force(Time time) => new(value * time);


	public static ForceAccel3 operator +(ForceAccel3 left, ForceAccel3 right) => Add(left, right);

	public static ForceAccel3 operator -(ForceAccel3 left, ForceAccel3 right) => Sub(left, right);

	public static ForceAccel3 operator *(ForceAccel3 left, ForceAccel3 right) => Mul(left, right);

	public static ForceAccel3 operator /(ForceAccel3 left, ForceAccel3 right) => Div(left, right);
}
}