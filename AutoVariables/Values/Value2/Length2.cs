using UnityEngine;
using System;

namespace AutoScaleVariables {
[Serializable]
public class Length2 : Value2<Length> {
	public Length2(Vector2 value, float scale = 1) : base(value, scale) { }

	public Length2() { }

	public static Length2 operator +(Length2 left, Velocity2 right) => Add(left, right.Length2(Time.deltaTime));

	public static Length2 operator -(Length2 left, Velocity2 right) => Sub(left, right.Length2(Time.deltaTime));

	public static Length2 operator +(Length2 left, Length2 right) => Add(left, right);

	public static Length2 operator -(Length2 left, Length2 right) => Sub(left, right);

	public static Length2 operator *(Length2 left, Length2 right) => Mul(left, right);

	public static Length2 operator /(Length2 left, Length2 right) => Div(left, right);
}
}