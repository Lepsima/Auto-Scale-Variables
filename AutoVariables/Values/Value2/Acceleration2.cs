using UnityEngine;
using System;

namespace AutoScaleVariables {
[Serializable]
public class Acceleration2 : Value2<Acceleration> {
	public Acceleration2(Vector2 value, float scale = 1) : base(value, scale) { }

	public Acceleration2(Force2 force, Mass mass) : base(force.value / mass.AsKiloGram()) { }

	public Acceleration2() { }

	public Velocity2 Velocity2(Time time) => new(value * time);

	public static Force2 operator *(Acceleration2 left, Mass right) => new(left.value * right.AsKiloGram());

	public static Force2 operator *(Mass left, Acceleration2 right) => new(right.value * left.AsKiloGram());

	public static Acceleration2 operator +(Acceleration2 left, Acceleration2 right) => Add(left, right);

	public static Acceleration2 operator -(Acceleration2 left, Acceleration2 right) => Sub(left, right);

	public static Acceleration2 operator *(Acceleration2 left, Acceleration2 right) => Mul(left, right);

	public static Acceleration2 operator /(Acceleration2 left, Acceleration2 right) => Div(left, right);
}
}