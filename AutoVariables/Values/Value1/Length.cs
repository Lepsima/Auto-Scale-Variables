using System;

namespace AutoScaleVariables {
[Serializable]
public class Length : Value {
	public Length(float value, float scale = 1) : base(value, scale) { }

	public static Length operator +(Length left, Velocity right) => Add(left, right.Length(Time.deltaTime));

	public static Length operator -(Length left, Velocity right) => Sub(left, right.Length(Time.deltaTime));

	public static Length operator +(Length left, Length right) => Add(left, right);

	public static Length operator -(Length left, Length right) => Sub(left, right);

	public static Length operator *(Length left, Length right) => Mul(left, right);

	public static Length operator /(Length left, Length right) => Div(left, right);
}
}