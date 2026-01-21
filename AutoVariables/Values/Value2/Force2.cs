using UnityEngine;
using System;

namespace AutoScaleVariables {
[Serializable]
public class Force2 : Value2 {
	public Force2(Vector2 value, float scale = 1) : base(value, scale) { }
	public Force2(Acceleration2 accel, Mass mass) : base(accel * mass) { }

	public static Force2 operator +(Force2 left, Force2 right) => Add(left, right);

	public static Force2 operator -(Force2 left, Force2 right) => Sub(left, right);

	public static Force2 operator *(Force2 left, Force2 right) => Mul(left, right);

	public static Force2 operator /(Force2 left, Force2 right) => Div(left, right);
}
}