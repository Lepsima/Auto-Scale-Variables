using UnityEngine;
using static AutoScaleVariables.Unit;

namespace AutoScaleVariables {
public static partial class Unit {
	public static Velocity3 KilometerHour(Vector3 value) {
		Length3 km = KiloMeter(value);
		Time hour = Hour(1);
		return new Velocity3(km, hour);
	}

	public static Angle3 Degree(Vector3 value) => new(value);

	public static Angle3 MinuteDegree(Vector3 value) => new(value, 0.016666666666666666f);

	public static Angle3 SecondDegree(Vector3 value) => new(value, 0.0002777777777777778f);

	public static Angle3 Radian(Vector3 value) => new(value, 0.01745329238474369f);

	public static Angle3 Turn(Vector3 value) => new(value, 360);

	public static Velocity3 KilometerHour(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		Length3 km = KiloMeter(value);
		Time hour = Hour(1);
		return new Velocity3(km, hour);
	}

	public static Angle3 Degree(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Angle3(value);
	}

	public static Angle3 MinuteDegree(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Angle3(value, 0.016666666666666666f);
	}

	public static Angle3 SecondDegree(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Angle3(value, 0.0002777777777777778f);
	}

	public static Angle3 Radian(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Angle3(value, 0.01745329238474369f);
	}

	public static Angle3 Turn(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Angle3(value, 360);
	}
}
}