using System;

namespace AutoScaleVariables {
[Serializable]
public class Force : Value {
	public Force(float value, float scale = 1) : base(value, scale) { }

	public Force(Acceleration accel, Mass mass) : base(accel * mass) { }

	public Force() { }

	public static Force operator +(Force left, Force right) => Add(left, right);

	public static Force operator -(Force left, Force right) => Sub(left, right);

	public static Force operator *(Force left, Force right) => Mul(left, right);

	public static Force operator /(Force left, Force right) => Div(left, right);
}
}