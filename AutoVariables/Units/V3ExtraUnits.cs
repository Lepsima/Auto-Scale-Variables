using UnityEngine;
using static AutoScaleVariables.Unit;

namespace AutoScaleVariables {
public static partial class Unit {
	public static Length3 Feet(Vector3 value) => new(value, 3.280839895f);
	
	public static Length3 Mile(Vector3 value) => new(value, 1609.344f);
	
	public static Length3 Feet(float x, float y, float z) {
		return new Length3(new Vector3(x, y, z), 3.280839895f);
	}
	
	public static Length3 Mile(float x, float y, float z) {
		return new Length3(new Vector3(x, y, z), 1609.344f);
	}
	public static Velocity3 FeetSecond(Vector3 value) {
		return new Velocity3(Feet(value), 1);
	}
	
	public static Velocity3 MileHour(Vector3 value) {
		return new Velocity3(Mile(value), Hour(1));
	}
	
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