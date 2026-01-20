using UnityEngine;
using static AutoScaleVariables.Unit;

namespace AutoScaleVariables {
public static partial class Unit {
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