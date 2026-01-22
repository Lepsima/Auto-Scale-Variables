using UnityEngine;
using static AutoScaleVariables.Unit;

namespace AutoScaleVariables {
public static partial class Unit {
	
	public static Length2 Feet(Vector2 value) => new(value, 3.280839895f);
	
	public static Length2 Mile(Vector2 value) => new(value, 1609.344f);
	
	public static Length2 Feet(float x, float y) {
		return new Length2(new Vector2(x, y), 3.280839895f);
	}
	
	public static Length2 Mile(float x, float y) {
		return new Length2(new Vector2(x, y), 1609.344f);
	}
	
	public static Velocity2 FeetSecond(Vector2 value) {
		return new Velocity2(Feet(value), 1);
	}
	
	public static Velocity2 MileHour(Vector2 value) {
		return new Velocity2(Mile(value), Hour(1));
	}
	public static Velocity2 KilometerHour(Vector2 value) {
		Length2 km = KiloMeter(value);
		Time hour = Hour(1);
		return new Velocity2(km, hour);
	}

	public static Angle2 Degree(Vector2 value) => new(value);

	public static Angle2 MinuteDegree(Vector2 value) => new(value, 0.016666666666666666f);

	public static Angle2 SecondDegree(Vector2 value) => new(value, 0.0002777777777777778f);

	public static Angle2 Radian(Vector2 value) => new(value, 0.01745329238474369f);

	public static Angle2 Turn(Vector2 value) => new(value, 360);

	public static Velocity2 KilometerHour(float x, float y) {
		Vector2 value = new(x, y);
		Length2 km = KiloMeter(value);
		Time hour = Hour(1);
		return new Velocity2(km, hour);
	}

	public static Angle2 Degree(float x, float y) {
		Vector2 value = new(x, y);
		return new Angle2(value);
	}

	public static Angle2 MinuteDegree(float x, float y) {
		Vector2 value = new(x, y);
		return new Angle2(value, 0.016666666666666666f);
	}

	public static Angle2 SecondDegree(float x, float y) {
		Vector2 value = new(x, y);
		return new Angle2(value, 0.0002777777777777778f);
	}

	public static Angle2 Radian(float x, float y) {
		Vector2 value = new(x, y);
		return new Angle2(value, 0.01745329238474369f);
	}

	public static Angle2 Turn(float x, float y) {
		Vector2 value = new(x, y);
		return new Angle2(value, 360);
	}
}
}