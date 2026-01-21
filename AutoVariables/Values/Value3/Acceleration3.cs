using UnityEngine;
using System;

namespace AutoScaleVariables {
[Serializable]
public class Acceleration3 : Value3 {
	public Acceleration3(Vector3 value, float scale = 1) : base(value, scale) { }
	public Acceleration3(Force3 force, Mass mass) : base(force.value / mass.value) { }

	public Velocity3 Velocity3(Time time) => new(value * time);

	public static Force3 operator *(Acceleration3 left, Mass right) => new(left.value * right.value);

	public static Force3 operator *(Mass left, Acceleration3 right) => new(right.value * left.value);

	public static Acceleration3 operator +(Acceleration3 left, Acceleration3 right) => Add(left, right);

	public static Acceleration3 operator -(Acceleration3 left, Acceleration3 right) => Sub(left, right);
}
}