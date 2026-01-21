using System;

namespace AutoScaleVariables {
[Serializable]
public class Mass : Value {
	public Mass(float value, float scale = 1) : base(value, scale) { }

	public static Mass operator +(Mass left, Mass right) => Add(left, right);

	public static Mass operator -(Mass left, Mass right) => Sub(left, right);

	public static Mass operator *(Mass left, Mass right) => Mul(left, right);

	public static Mass operator /(Mass left, Mass right) => Div(left, right);
}
}