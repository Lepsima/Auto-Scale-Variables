using UnityEngine;

namespace AutoScaleVariables {
public class Direction2 : Value2<Magnitude> {
	public Direction2(Vector2 value, float scale = 1) : base(value, scale) { }

	public override Direction2 normalized => this;

	public override Magnitude sqrMagnitude => new(1);
	public override Magnitude magnitude => new(1);
	
	
	public static Velocity2 operator *(Direction2 left, Velocity right) => new(left.value * right.value);
	public static Velocity2 operator *(Velocity left, Direction2 right) => new(left.value * right.value);
	
	public static Length2 operator *(Direction2 left, Length right) => new(left.value * right.value);
	public static Length2 operator *(Length left, Direction2 right) => new(left.value * right.value);
	
	public static Force2 operator *(Direction2 left, Force right) => new(left.value * right.value);
	public static Force2 operator *(Force left, Direction2 right) => new(left.value * right.value);
	
	public static ForceAccel2 operator *(Direction2 left, ForceAccel right) => new(left.value * right.value);
	public static ForceAccel2 operator *(ForceAccel left, Direction2 right) => new(left.value * right.value);
	
	public static Const2 operator *(Direction2 left, Const right) => new(left.value * right.value);
	public static Const2 operator *(Const left, Direction2 right) => new(left.value * right.value);
	
	public static Acceleration2 operator *(Direction2 left, Acceleration right) => new(left.value * right.value);
	public static Acceleration2 operator *(Acceleration left, Direction2 right) => new(left.value * right.value);
	
	public static Angle2 operator *(Direction2 left, Angle right) => new(left.value * right.value);
	public static Angle2 operator *(Angle left, Direction2 right) => new(left.value * right.value);
}
}