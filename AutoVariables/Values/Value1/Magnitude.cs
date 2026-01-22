using UnityEngine;

namespace AutoScaleVariables {
public class Magnitude : Value {
	public Magnitude(float value, float scale = 1) : base(value, scale) { }

	public Magnitude() { }
	
	
	// Acceleration
	public static Acceleration operator *(Acceleration left, Magnitude right) => new(left.value * right.value);
	public static Acceleration operator *(Magnitude left, Acceleration right) => new(left.value * right.value);

	// Angle
	public static Angle operator *(Angle left, Magnitude right) => new(left.value * right.value);
	public static Angle operator *(Magnitude left, Angle right) => new(left.value * right.value);

	// Const
	public static Const operator *(Const left, Magnitude right) => new(left.value * right.value);
	public static Const operator *(Magnitude left, Const right) => new(left.value * right.value);

	// Force
	public static Force operator *(Force left, Magnitude right) => new(left.value * right.value);
	public static Force operator *(Magnitude left, Force right) => new(left.value * right.value);

	// ForceAccel
	public static ForceAccel operator *(ForceAccel left, Magnitude right) => new(left.value * right.value);
	public static ForceAccel operator *(Magnitude left, ForceAccel right) => new(left.value * right.value);

	// Length
	public static Length operator *(Length left, Magnitude right) => new(left.value * right.value);
	public static Length operator *(Magnitude left, Length right) => new(left.value * right.value);

	// Mass
	public static Mass operator *(Mass left, Magnitude right) => new(left.value * right.value);
	public static Mass operator *(Magnitude left, Mass right) => new(left.value * right.value);

	// Time
	public static Time operator *(Time left, Magnitude right) => new(left.value * right.value);
	public static Time operator *(Magnitude left, Time right) => new(left.value * right.value);

	// Velocity
	public static Velocity operator *(Velocity left, Magnitude right) => new(left.value * right.value);
	public static Velocity operator *(Magnitude left, Velocity right) => new(left.value * right.value);

	// Acceleration2
	public static Acceleration2 operator *(Acceleration2 left, Magnitude right) => new(left.value * right.value);
	public static Acceleration2 operator *(Magnitude left, Acceleration2 right) => new(left.value * right.value);

	// Angle2
	public static Angle2 operator *(Angle2 left, Magnitude right) => new(left.value * right.value);
	public static Angle2 operator *(Magnitude left, Angle2 right) => new(left.value * right.value);

	// Const2
	public static Const2 operator *(Const2 left, Magnitude right) => new(left.value * right.value);
	public static Const2 operator *(Magnitude left, Const2 right) => new(left.value * right.value);

	// Force2
	public static Force2 operator *(Force2 left, Magnitude right) => new(left.value * right.value);
	public static Force2 operator *(Magnitude left, Force2 right) => new(left.value * right.value);

	// ForceAccel2
	public static ForceAccel2 operator *(ForceAccel2 left, Magnitude right) => new(left.value * right.value);
	public static ForceAccel2 operator *(Magnitude left, ForceAccel2 right) => new(left.value * right.value);

	// Length2
	public static Length2 operator *(Length2 left, Magnitude right) => new(left.value * right.value);
	public static Length2 operator *(Magnitude left, Length2 right) => new(left.value * right.value);

	// Velocity2
	public static Velocity2 operator *(Velocity2 left, Magnitude right) => new(left.value * right.value);
	public static Velocity2 operator *(Magnitude left, Velocity2 right) => new(left.value * right.value);

	// Acceleration3
	public static Acceleration3 operator *(Acceleration3 left, Magnitude right) => new(left.value * right.value);
	public static Acceleration3 operator *(Magnitude left, Acceleration3 right) => new(left.value * right.value);

	// Angle3
	public static Angle3 operator *(Angle3 left, Magnitude right) => new(left.value * right.value);
	public static Angle3 operator *(Magnitude left, Angle3 right) => new(left.value * right.value);

	// Const3
	public static Const3 operator *(Const3 left, Magnitude right) => new(left.value * right.value);
	public static Const3 operator *(Magnitude left, Const3 right) => new(left.value * right.value);

	// Force3
	public static Force3 operator *(Force3 left, Magnitude right) => new(left.value * right.value);
	public static Force3 operator *(Magnitude left, Force3 right) => new(left.value * right.value);

	// ForceAccel3
	public static ForceAccel3 operator *(ForceAccel3 left, Magnitude right) => new(left.value * right.value);
	public static ForceAccel3 operator *(Magnitude left, ForceAccel3 right) => new(left.value * right.value);

	// Length3
	public static Length3 operator *(Length3 left, Magnitude right) => new(left.value * right.value);
	public static Length3 operator *(Magnitude left, Length3 right) => new(left.value * right.value);

	// Velocity3
	public static Velocity3 operator *(Velocity3 left, Magnitude right) => new(left.value * right.value);
	public static Velocity3 operator *(Magnitude left, Velocity3 right) => new(left.value * right.value);
}
}