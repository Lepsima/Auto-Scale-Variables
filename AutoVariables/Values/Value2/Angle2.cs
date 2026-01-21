using UnityEngine;
using System;

namespace AutoScaleVariables {
[Serializable]
public class Angle2 : Value2 {
	public Angle2(Vector2 value, float scale = 1) : base(value, scale) { }

	public static Angle2 operator +(Angle2 left, Angle2 right) => Add(left, right);

	public static Angle2 operator -(Angle2 left, Angle2 right) => Sub(left, right);

	public static Angle2 operator *(Angle2 left, Angle2 right) => Mul(left, right);

	public static Angle2 operator /(Angle2 left, Angle2 right) => Div(left, right);
}
}