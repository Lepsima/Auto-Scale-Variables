using Unity.VisualScripting;
using UnityEngine;
using static AutoScaleVariables.Scales;

namespace AutoScaleVariables {
public abstract partial class Scales {
	public static Velocity KilometerHour(float value) {
		Length km = KiloMeter(value);
		Time hour = Hour(1);
		return new Velocity(km, hour);
	}
	
	public static ForceAccel NewtonSecond(float value) {
		return new ForceAccel(value);
	}

	public static Time Minute(float value) {
		return new Time(value, 60);
	}

	public static Time Hour(float value) {
		return new Time(value, 3600f);
	}

	public static Angle Degree(float value) {
		return new Angle(value);
	}

	public static Angle MinuteDegree(float value) {
		return new Angle(value, 0.016666666666666666f);
	}

	public static Angle SecondDegree(float value) {
		return new Angle(value, 0.0002777777777777778f);
	}

	public static Angle Radian(float value) {
		return new Angle(value, 0.01745329238474369f);
	}

	public static Angle Turn(float value) {
		return new Angle(value, 360);
	}

	public static Mass Ton(float value) {
		return MegaGram(value);
	}

	public static Time MicroSecond(float value) {
		return new Time(value, 0.000001f);
	}

	public static Time MilliSecond(float value) {
		return new Time(value, 0.001f);
	}

	public static Time CentiSecond(float value) {
		return new Time(value, 0.01f);
	}

	public static Time DeciSecond(float value) {
		return new Time(value, 0.1f);
	}

	public static Time Second(float value) {
		return new Time(value);
	}

	public static Time DecaSecond(float value) {
		return new Time(value, 10);
	}

	public static Time HectoSecond(float value) {
		return new Time(value, 100);
	}

	public static Time KiloSecond(float value) {
		return new Time(value, 1000);
	}

	public static Time MegaSecond(float value) {
		return new Time(value, 1000000);
	}

	public static Mass MicroGram(float value) {
		return new Mass(value, 0.000001f);
	}

	public static Mass MilliGram(float value) {
		return new Mass(value, 0.001f);
	}

	public static Mass CentiGram(float value) {
		return new Mass(value, 0.01f);
	}

	public static Mass DeciGram(float value) {
		return new Mass(value, 0.1f);
	}

	public static Mass Gram(float value) {
		return new Mass(value);
	}

	public static Mass DecaGram(float value) {
		return new Mass(value, 10);
	}

	public static Mass HectoGram(float value) {
		return new Mass(value, 100);
	}

	public static Mass KiloGram(float value) {
		return new Mass(value, 1000);
	}

	public static Mass MegaGram(float value) {
		return new Mass(value, 1000000);
	}

	public static Force MicroNewton(float value) {
		return new Force(value, 0.000001f);
	}

	public static Force MilliNewton(float value) {
		return new Force(value, 0.001f);
	}

	public static Force CentiNewton(float value) {
		return new Force(value, 0.01f);
	}

	public static Force DeciNewton(float value) {
		return new Force(value, 0.1f);
	}

	public static Force Newton(float value) {
		return new Force(value);
	}

	public static Force DecaNewton(float value) {
		return new Force(value, 10);
	}

	public static Force HectoNewton(float value) {
		return new Force(value, 100);
	}

	public static Force KiloNewton(float value) {
		return new Force(value, 1000);
	}

	public static Force MegaNewton(float value) {
		return new Force(value, 1000000);
	}

	public static Length MicroMeter(float value) {
		return new Length(value, 0.000001f);
	}

	public static Length MilliMeter(float value) {
		return new Length(value, 0.001f);
	}

	public static Length CentiMeter(float value) {
		return new Length(value, 0.01f);
	}

	public static Length DeciMeter(float value) {
		return new Length(value, 0.1f);
	}

	public static Length Meter(float value) {
		return new Length(value);
	}

	public static Length DecaMeter(float value) {
		return new Length(value, 10);
	}

	public static Length HectoMeter(float value) {
		return new Length(value, 100);
	}

	public static Length KiloMeter(float value) {
		return new Length(value, 1000);
	}

	public static Length MegaMeter(float value) {
		return new Length(value, 1000000);
	}

	public static Velocity MicroMeterSecond(float value) {
		return new Velocity(value, 0.000001f);
	}

	public static Velocity MilliMeterSecond(float value) {
		return new Velocity(value, 0.001f);
	}

	public static Velocity CentiMeterSecond(float value) {
		return new Velocity(value, 0.01f);
	}

	public static Velocity DeciMeterSecond(float value) {
		return new Velocity(value, 0.1f);
	}

	public static Velocity MeterSecond(float value) {
		return new Velocity(value);
	}

	public static Velocity DecaMeterSecond(float value) {
		return new Velocity(value, 10);
	}

	public static Velocity HectoMeterSecond(float value) {
		return new Velocity(value, 100);
	}

	public static Velocity KiloMeterSecond(float value) {
		return new Velocity(value, 1000);
	}

	public static Velocity MegaMeterSecond(float value) {
		return new Velocity(value, 1000000);
	}

	public static Acceleration MicroMeterS2(float value) {
		return new Acceleration(value, 0.000001f);
	}

	public static Acceleration MilliMeterS2(float value) {
		return new Acceleration(value, 0.001f);
	}

	public static Acceleration CentiMeterS2(float value) {
		return new Acceleration(value, 0.01f);
	}

	public static Acceleration DeciMeterS2(float value) {
		return new Acceleration(value, 0.1f);
	}

	public static Acceleration MeterS2(float value) {
		return new Acceleration(value);
	}

	public static Acceleration DecaMeterS2(float value) {
		return new Acceleration(value, 10);
	}

	public static Acceleration HectoMeterS2(float value) {
		return new Acceleration(value, 100);
	}

	public static Acceleration KiloMeterS2(float value) {
		return new Acceleration(value, 1000);
	}

	public static Acceleration MegaMeterS2(float value) {
		return new Acceleration(value, 1000000);
	}
}

public class Time : Value {
	private static readonly Time _static = Second(0);

	public Time(float value, float scale = 1) : base(value, scale) { }

	public static Time deltaTime {
		get {
			_static.value = UnityEngine.Time.deltaTime;
			return _static;
		}
	}

	public static Time time {
		get {
			_static.value = UnityEngine.Time.time;
			return _static;
		}
	}

	public static Time operator +(Time left, Time right) {
		return Add(left, right);
	}

	public static Time operator -(Time left, Time right) {
		return Sub(left, right);
	}

	public static Time operator *(Time left, Time right) {
		return Mul(left, right);
	}

	public static Time operator /(Time left, Time right) {
		return Div(left, right);
	}
}

public class Mass : Value {
	public Mass(float value, float scale = 1) : base(value, scale) { }

	public static Mass operator +(Mass left, Mass right) {
		return Add(left, right);
	}

	public static Mass operator -(Mass left, Mass right) {
		return Sub(left, right);
	}

	public static Mass operator *(Mass left, Mass right) {
		return Mul(left, right);
	}

	public static Mass operator /(Mass left, Mass right) {
		return Div(left, right);
	}
}

public class Force : Value {
	public Force(float value, float scale = 1) : base(value, scale) { }

	public Force(Acceleration accel, Mass mass) : base(accel * mass) { }

	public static Force operator +(Force left, Force right) {
		return Add(left, right);
	}

	public static Force operator -(Force left, Force right) {
		return Sub(left, right);
	}

	public static Force operator *(Force left, Force right) {
		return Mul(left, right);
	}

	public static Force operator /(Force left, Force right) {
		return Div(left, right);
	}
}

public class ForceAccel : Value {
	public ForceAccel(float value, float scale = 1) : base(value, scale) { }

	public Force Force(Time time) {
		return new Force(value * time);
	}
	
	public static Force operator +(Force left, ForceAccel right) {
		return Add(left, right.Force(Time.deltaTime));
	}

	public static Force operator -(Force left, ForceAccel right) {
		return Sub(left, right.Force(Time.deltaTime));
	}
	
	public static ForceAccel operator +(ForceAccel left, ForceAccel right) {
		return Add(left, right);
	}

	public static ForceAccel operator -(ForceAccel left, ForceAccel right) {
		return Sub(left, right);
	}

	public static ForceAccel operator *(ForceAccel left, ForceAccel right) {
		return Mul(left, right);
	}

	public static ForceAccel operator /(ForceAccel left, ForceAccel right) {
		return Div(left, right);
	}
}

public class Length : Value {
	public Length(float value, float scale = 1) : base(value, scale) { }
	
	public static Length operator +(Length left, Velocity right) {
		return Add(left, right.Length(Time.deltaTime));
	}

	public static Length operator -(Length left, Velocity right) {
		return Sub(left, right.Length(Time.deltaTime));
	}

	public static Length operator +(Length left, Length right) {
		return Add(left, right);
	}

	public static Length operator -(Length left, Length right) {
		return Sub(left, right);
	}

	public static Length operator *(Length left, Length right) {
		return Mul(left, right);
	}

	public static Length operator /(Length left, Length right) {
		return Div(left, right);
	}
}

public class Velocity : Value {
	public Velocity(float value, float scale = 1) : base(value, scale) { }

	public Velocity(Length length, Time time) : base(length.value / time.value) { }
	
	public Length Length(Time time) {
		return new Length(value * time);
	}

	public static Velocity operator +(Velocity left, Acceleration right) {
		return Add(left, right.Velocity(Time.deltaTime));
	}

	public static Velocity operator -(Velocity left, Acceleration right) {
		return Sub(left, right.Velocity(Time.deltaTime));
	}

	public static Velocity operator +(Velocity left, Velocity right) {
		return Add(left, right);
	}

	public static Velocity operator -(Velocity left, Velocity right) {
		return Sub(left, right);
	}

	public static Velocity operator *(Velocity left, Velocity right) {
		return Mul(left, right);
	}

	public static Velocity operator /(Velocity left, Velocity right) {
		return Div(left, right);
	}
}

public class Acceleration : Value {
	public Acceleration(float value, float scale = 1) : base(value, scale) { }

	public Acceleration(Force force, Mass mass) : base(force.value / mass.value) { }

	public Velocity Velocity(Time time) {
		return new Velocity(value * time);
	}
	
	public static Acceleration2 operator *(Vector2 left, Acceleration right) => new(left.normalized * right.value);
	public static Acceleration2 operator *(Acceleration left, Vector2 right) => new(right.normalized * left.value);
	public static Acceleration3 operator *(Vector3 left, Acceleration right) => new(left.normalized * right.value);
	public static Acceleration3 operator *(Acceleration left, Vector3 right) => new(right.normalized * left.value);
	

	public static Acceleration operator +(Acceleration left, Acceleration right) {
		return Add(left, right);
	}

	public static Acceleration operator -(Acceleration left, Acceleration right) {
		return Sub(left, right);
	}

	public static Acceleration operator *(Acceleration left, Acceleration right) {
		return Mul(left, right);
	}

	public static Acceleration operator /(Acceleration left, Acceleration right) {
		return Div(left, right);
	}
}

public class Angle : Value {
	public Angle(float value, float scale = 1) : base(value, scale) { }

	public static Angle operator +(Angle left, Angle right) {
		return Add(left, right);
	}

	public static Angle operator -(Angle left, Angle right) {
		return Sub(left, right);
	}

	public static Angle operator *(Angle left, Angle right) {
		return Mul(left, right);
	}

	public static Angle operator /(Angle left, Angle right) {
		return Div(left, right);
	}
}

public class Value {
	protected Value(float value, float scale = 1) {
		this.value = value * scale;
	}

	public float value { get; set; }

	public static implicit operator float(Value v) => v.value;

	protected static T Add<T>(T left, T right) where T : Value {
		left.value = (float)left + right;
		return left;
	}

	protected static T Sub<T>(T left, T right) where T : Value {
		left.value = (float)left - right;
		return left;
	}

	protected static T Mul<T>(T left, T right) where T : Value {
		left.value = (float)left * right;
		return left;
	}

	protected static T Div<T>(T left, T right) where T : Value {
		left.value = (float)left / right;
		return left;
	}
}
}