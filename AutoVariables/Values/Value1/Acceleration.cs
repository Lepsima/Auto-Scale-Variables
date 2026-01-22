using System;
using UnityEngine;

namespace AutoScaleVariables {
[Serializable]
public class Acceleration : Value {
	public Acceleration(float value, float scale = 1) : base(value, scale) { }

	public Acceleration(Force force, Mass mass) : base(force.value / mass.AsKiloGram()) { }

	public Acceleration() { }

	public Velocity Velocity(Time time) => new(value * time);

	public static Acceleration2 operator *(Vector2 left, Acceleration right) => new(left.normalized * right.value);
	public static Acceleration2 operator *(Acceleration left, Vector2 right) => new(right.normalized * left.value);
	public static Acceleration3 operator *(Vector3 left, Acceleration right) => new(left.normalized * right.value);
	public static Acceleration3 operator *(Acceleration left, Vector3 right) => new(right.normalized * left.value);


	public static Acceleration operator +(Acceleration left, Acceleration right) => Add(left, right);

	public static Acceleration operator -(Acceleration left, Acceleration right) => Sub(left, right);

	public static Acceleration operator *(Acceleration left, Acceleration right) => Mul(left, right);

	public static Acceleration operator /(Acceleration left, Acceleration right) => Div(left, right);
}
}