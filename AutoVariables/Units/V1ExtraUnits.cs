using UnityEngine;
using static AutoScaleVariables.Unit;

namespace AutoScaleVariables {
public static partial class Unit {
	public static Length Feet(float value) => new(value, 3.280839895f);
	
	public static Length Mile(float value) => new(value, 1609.344f);

	public static Velocity FeetSecond(float value) {
		return new Velocity(Feet(value), 1);
	}
	
	public static Velocity MileHour(float value) {
		return new Velocity(Mile(value), Hour(1));
	}
	
	public static Velocity KilometerHour(float value) {
		Length km = KiloMeter(value);
		Time hour = Hour(1);
		return new Velocity(km, hour);
	}

	public static ForceAccel NewtonSecond(float value) => new(value);

	public static Time Minute(float value) => new(value, 60);

	public static Time Hour(float value) => new(value, 3600f);

	public static Angle Degree(float value) => new(value);

	public static Angle MinuteDegree(float value) => new(value, 0.016666666666666666f);

	public static Angle SecondDegree(float value) => new(value, 0.0002777777777777778f);

	public static Angle Radian(float value) => new(value, 0.01745329238474369f);

	public static Angle Turn(float value) => new(value, 360);

	public static Mass Ton(float value) => MegaGram(value);
}
}