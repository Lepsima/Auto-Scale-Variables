using UnityEngine;
using System;

namespace AutoScaleVariables {
[Serializable]
public class Force2 : Value2<Force> {
	public Force2(Vector2 value, float scale = 1) : base(value, scale) { }
	public Force2(Acceleration2 accel, Mass mass) : base(accel * mass) { }

	public Force2() { }
	
	public static Force2 operator +(Force2 left, ForceAccel2 right) => Add(left, right.Force2(Time.deltaTime));

	public static Force2 operator -(Force2 left, ForceAccel2 right) => Sub(left, right.Force2(Time.deltaTime));

	public static Force2 operator +(Force2 left, Force2 right) => Add(left, right);

	public static Force2 operator -(Force2 left, Force2 right) => Sub(left, right);

	public static Force2 operator *(Force2 left, Force2 right) => Mul(left, right);

	public static Force2 operator /(Force2 left, Force2 right) => Div(left, right);
}
}