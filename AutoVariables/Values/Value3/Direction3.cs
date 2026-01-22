using UnityEngine;

namespace AutoScaleVariables {
public class Direction3 : Value3<Magnitude> {
	public Direction3(Vector3 value, float scale = 1) : base(value.normalized, scale) { }

	public override Direction3 normalized => this;

	public override Magnitude sqrMagnitude => new(1);
	public override Magnitude magnitude => new(1);
	
	public static Velocity3 operator *(Direction3 left, Velocity right) => new(left.value * right.value);
	public static Velocity3 operator *(Velocity left, Direction3 right) => new(left.value * right.value);
	
	public static Length3 operator *(Direction3 left, Length right) => new(left.value * right.value);
	public static Length3 operator *(Length left, Direction3 right) => new(left.value * right.value);
	
	public static Force3 operator *(Direction3 left, Force right) => new(left.value * right.value);
	public static Force3 operator *(Force left, Direction3 right) => new(left.value * right.value);
	
	public static ForceAccel3 operator *(Direction3 left, ForceAccel right) => new(left.value * right.value);
	public static ForceAccel3 operator *(ForceAccel left, Direction3 right) => new(left.value * right.value);
	
	public static Const3 operator *(Direction3 left, Const right) => new(left.value * right.value);
	public static Const3 operator *(Const left, Direction3 right) => new(left.value * right.value);
	
	public static Acceleration3 operator *(Direction3 left, Acceleration right) => new(left.value * right.value);
	public static Acceleration3 operator *(Acceleration left, Direction3 right) => new(left.value * right.value);
	
	public static Angle3 operator *(Direction3 left, Angle right) => new(left.value * right.value);
	public static Angle3 operator *(Angle left, Direction3 right) => new(left.value * right.value);
}
}