using UnityEngine;
using System;

namespace AutoScaleVariables {
[Serializable]
public class Velocity2 : Value2<Velocity> {
	public Velocity2(Vector2 value, float scale = 1) : base(value, scale) { }

	public Velocity2(Length2 length, Time time) : base(length.value / time.value) { }

	public Velocity2() { }

	public Length2 Length2(Time time) => new(value * time);

	public static Velocity2 operator +(Velocity2 left, Acceleration2 right) =>
		Add(left, right.Velocity2(Time.deltaTime));

	public static Velocity2 operator -(Velocity2 left, Acceleration2 right) =>
		Sub(left, right.Velocity2(Time.deltaTime));

	public static Velocity2 operator +(Velocity2 left, Velocity2 right) => Add(left, right);

	public static Velocity2 operator -(Velocity2 left, Velocity2 right) => Sub(left, right);

	public static Velocity2 operator *(Velocity2 left, Velocity2 right) => Mul(left, right);

	public static Velocity2 operator /(Velocity2 left, Velocity2 right) => Div(left, right);
}
}