using UnityEngine;
using System;

namespace AutoScaleVariables {
[Serializable]
public class Length3 : Value3<Length> {
	public Length3(Vector3 value, float scale = 1) : base(value, scale) { }

	public Length3() { }

	public static Length3 operator +(Length3 left, Velocity3 right) => Add(left, right.Length3(Time.deltaTime));

	public static Length3 operator -(Length3 left, Velocity3 right) => Sub(left, right.Length3(Time.deltaTime));

	public static Length3 operator +(Length3 left, Length3 right) => Add(left, right);

	public static Length3 operator -(Length3 left, Length3 right) => Sub(left, right);
	
	public static Length3 operator *(Length3 left, Length3 right) => Mul(left, right);

	public static Length3 operator /(Length3 left, Length3 right) => Div(left, right);
}
}