using UnityEngine;
using System;

namespace AutoScaleVariables {
[Serializable]
public class Angle3 : Value3<Angle> {
	public Angle3(Vector3 value, float scale = 1) : base(value, scale) { }

	public Angle3() { }

	public static Angle3 operator +(Angle3 left, Angle3 right) => Add(left, right);

	public static Angle3 operator -(Angle3 left, Angle3 right) => Sub(left, right);
	
	public static Angle3 operator *(Angle3 left, Angle3 right) => Mul(left, right);

	public static Angle3 operator /(Angle3 left, Angle3 right) => Div(left, right);
}
}