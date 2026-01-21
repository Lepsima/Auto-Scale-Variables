using UnityEngine;
using System;

namespace AutoScaleVariables {
[Serializable]
public class Velocity3 : Value3<Velocity> {
	public Velocity3(Vector3 value, float scale = 1) : base(value, scale) { }
	public Velocity3(Length3 length, Time time) : base(length.value / time.value) { }

	public Velocity3() { }

	public Length3 Length3(Time time) => new(value * time);

	public static Velocity3 operator +(Velocity3 left, Acceleration3 right) =>
		Add(left, right.Velocity3(Time.deltaTime));

	public static Velocity3 operator -(Velocity3 left, Acceleration3 right) =>
		Sub(left, right.Velocity3(Time.deltaTime));

	public static Velocity3 operator +(Velocity3 left, Velocity3 right) => Add(left, right);

	public static Velocity3 operator -(Velocity3 left, Velocity3 right) => Sub(left, right);
	
	public static Velocity3 operator *(Velocity3 left, Velocity3 right) => Mul(left, right);

	public static Velocity3 operator /(Velocity3 left, Velocity3 right) => Div(left, right);
}
}