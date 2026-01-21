using UnityEngine;
using System;

namespace AutoScaleVariables {
[Serializable]
public class Force3 : Value3<Force> {
	public Force3(Acceleration3 accel, Mass mass) : base(accel * mass) { }

	public Force3(Vector3 value, float scale = 1) : base(value, scale) { }

	public Force3() { }

	public static Force3 operator +(Force3 left, Force3 right) => Add(left, right);

	public static Force3 operator -(Force3 left, Force3 right) => Sub(left, right);
	
	public static Force3 operator *(Force3 left, Force3 right) => Mul(left, right);

	public static Force3 operator /(Force3 left, Force3 right) => Div(left, right);
}
}