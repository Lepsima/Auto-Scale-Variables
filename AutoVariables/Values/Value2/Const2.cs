using System;
using UnityEngine;

namespace AutoScaleVariables {
[Serializable]
public class Const2 : Value2<Const> {
	public Const2(Vector2 value, float scale = 1) : base(value, scale) { }

	public Const2() { }

	public static Const2 operator +(Const2 left, Const2 right) => Add(left, right);

	public static Const2 operator -(Const2 left, Const2 right) => Sub(left, right);

	public static Const2 operator *(Const2 left, Const2 right) => Mul(left, right);

	public static Const2 operator /(Const2 left, Const2 right) => Div(left, right);
}
}