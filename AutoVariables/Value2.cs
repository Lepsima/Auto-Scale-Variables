using UnityEngine;
using static AutoScaleVariables.Scales;

namespace AutoScaleVariables {
public abstract partial class Scales {
	public static Force2 MicroNewton(Vector2 value) {
		return new Force2(value, 0.000001f);
	}

	public static Force2 MilliNewton(Vector2 value) {
		return new Force2(value, 0.001f);
	}

	public static Force2 CentiNewton(Vector2 value) {
		return new Force2(value, 0.01f);
	}

	public static Force2 DeciNewton(Vector2 value) {
		return new Force2(value, 0.1f);
	}

	public static Force2 Newton(Vector2 value) {
		return new Force2(value);
	}

	public static Force2 DecaNewton(Vector2 value) {
		return new Force2(value, 10);
	}

	public static Force2 HectoNewton(Vector2 value) {
		return new Force2(value, 100);
	}

	public static Force2 KiloNewton(Vector2 value) {
		return new Force2(value, 1000);
	}

	public static Force2 MegaNewton(Vector2 value) {
		return new Force2(value, 1000000);
	}

	public static Length2 MicroMeter(Vector2 value) {
		return new Length2(value, 0.000001f);
	}

	public static Length2 MilliMeter(Vector2 value) {
		return new Length2(value, 0.001f);
	}

	public static Length2 CentiMeter(Vector2 value) {
		return new Length2(value, 0.01f);
	}

	public static Length2 DeciMeter(Vector2 value) {
		return new Length2(value, 0.1f);
	}

	public static Length2 Meter(Vector2 value) {
		return new Length2(value);
	}

	public static Length2 DecaMeter(Vector2 value) {
		return new Length2(value, 10);
	}

	public static Length2 HectoMeter(Vector2 value) {
		return new Length2(value, 100);
	}

	public static Length2 KiloMeter(Vector2 value) {
		return new Length2(value, 1000);
	}

	public static Length2 MegaMeter(Vector2 value) {
		return new Length2(value, 1000000);
	}

	public static Velocity2 MicroMeterSecond(Vector2 value) {
		return new Velocity2(value, 0.000001f);
	}

	public static Velocity2 MilliMeterSecond(Vector2 value) {
		return new Velocity2(value, 0.001f);
	}

	public static Velocity2 CentiMeterSecond(Vector2 value) {
		return new Velocity2(value, 0.01f);
	}

	public static Velocity2 DeciMeterSecond(Vector2 value) {
		return new Velocity2(value, 0.1f);
	}

	public static Velocity2 MeterSecond(Vector2 value) {
		return new Velocity2(value);
	}

	public static Velocity2 DecaMeterSecond(Vector2 value) {
		return new Velocity2(value, 10);
	}

	public static Velocity2 HectoMeterSecond(Vector2 value) {
		return new Velocity2(value, 100);
	}

	public static Velocity2 KiloMeterSecond(Vector2 value) {
		return new Velocity2(value, 1000);
	}

	public static Velocity2 MegaMeterSecond(Vector2 value) {
		return new Velocity2(value, 1000000);
	}

	public static Acceleration2 MicroMeterS2(Vector2 value) {
		return new Acceleration2(value, 0.000001f);
	}

	public static Acceleration2 MilliMeterS2(Vector2 value) {
		return new Acceleration2(value, 0.001f);
	}

	public static Acceleration2 CentiMeterS2(Vector2 value) {
		return new Acceleration2(value, 0.01f);
	}

	public static Acceleration2 DeciMeterS2(Vector2 value) {
		return new Acceleration2(value, 0.1f);
	}

	public static Acceleration2 MeterS2(Vector2 value) {
		return new Acceleration2(value);
	}

	public static Acceleration2 DecaMeterS2(Vector2 value) {
		return new Acceleration2(value, 10);
	}

	public static Acceleration2 HectoMeterS2(Vector2 value) {
		return new Acceleration2(value, 100);
	}

	public static Acceleration2 KiloMeterS2(Vector2 value) {
		return new Acceleration2(value, 1000);
	}

	public static Acceleration2 MegaMeterS2(Vector2 value) {
		return new Acceleration2(value, 1000000);
	}

	public static Force2 MicroNewton(float x, float y) {
		Vector2 value = new(x, y);
		return new Force2(value, 0.000001f);
	}

	public static Force2 MilliNewton(float x, float y) {
		Vector2 value = new(x, y);
		return new Force2(value, 0.001f);
	}

	public static Force2 CentiNewton(float x, float y) {
		Vector2 value = new(x, y);
		return new Force2(value, 0.01f);
	}

	public static Force2 DeciNewton(float x, float y) {
		Vector2 value = new(x, y);
		return new Force2(value, 0.1f);
	}

	public static Force2 Newton(float x, float y) {
		Vector2 value = new(x, y);
		return new Force2(value);
	}

	public static Force2 DecaNewton(float x, float y) {
		Vector2 value = new(x, y);
		return new Force2(value, 10);
	}

	public static Force2 HectoNewton(float x, float y) {
		Vector2 value = new(x, y);
		return new Force2(value, 100);
	}

	public static Force2 KiloNewton(float x, float y) {
		Vector2 value = new(x, y);
		return new Force2(value, 1000);
	}

	public static Force2 MegaNewton(float x, float y) {
		Vector2 value = new(x, y);
		return new Force2(value, 1000000);
	}

	public static Length2 MicroMeter(float x, float y) {
		Vector2 value = new(x, y);
		return new Length2(value, 0.000001f);
	}

	public static Length2 MilliMeter(float x, float y) {
		Vector2 value = new(x, y);
		return new Length2(value, 0.001f);
	}

	public static Length2 CentiMeter(float x, float y) {
		Vector2 value = new(x, y);
		return new Length2(value, 0.01f);
	}

	public static Length2 DeciMeter(float x, float y) {
		Vector2 value = new(x, y);
		return new Length2(value, 0.1f);
	}

	public static Length2 Meter(float x, float y) {
		Vector2 value = new(x, y);
		return new Length2(value);
	}

	public static Length2 DecaMeter(float x, float y) {
		Vector2 value = new(x, y);
		return new Length2(value, 10);
	}

	public static Length2 HectoMeter(float x, float y) {
		Vector2 value = new(x, y);
		return new Length2(value, 100);
	}

	public static Length2 KiloMeter(float x, float y) {
		Vector2 value = new(x, y);
		return new Length2(value, 1000);
	}

	public static Length2 MegaMeter(float x, float y) {
		Vector2 value = new(x, y);
		return new Length2(value, 1000000);
	}

	public static Velocity2 MicroMeterSecond(float x, float y) {
		Vector2 value = new(x, y);
		return new Velocity2(value, 0.000001f);
	}

	public static Velocity2 MilliMeterSecond(float x, float y) {
		Vector2 value = new(x, y);
		return new Velocity2(value, 0.001f);
	}

	public static Velocity2 CentiMeterSecond(float x, float y) {
		Vector2 value = new(x, y);
		return new Velocity2(value, 0.01f);
	}

	public static Velocity2 DeciMeterSecond(float x, float y) {
		Vector2 value = new(x, y);
		return new Velocity2(value, 0.1f);
	}

	public static Velocity2 MeterSecond(float x, float y) {
		Vector2 value = new(x, y);
		return new Velocity2(value);
	}

	public static Velocity2 DecaMeterSecond(float x, float y) {
		Vector2 value = new(x, y);
		return new Velocity2(value, 10);
	}

	public static Velocity2 HectoMeterSecond(float x, float y) {
		Vector2 value = new(x, y);
		return new Velocity2(value, 100);
	}

	public static Velocity2 KiloMeterSecond(float x, float y) {
		Vector2 value = new(x, y);
		return new Velocity2(value, 1000);
	}

	public static Velocity2 MegaMeterSecond(float x, float y) {
		Vector2 value = new(x, y);
		return new Velocity2(value, 1000000);
	}

	public static Acceleration2 MicroMeterS2(float x, float y) {
		Vector2 value = new(x, y);
		return new Acceleration2(value, 0.000001f);
	}

	public static Acceleration2 MilliMeterS2(float x, float y) {
		Vector2 value = new(x, y);
		return new Acceleration2(value, 0.001f);
	}

	public static Acceleration2 CentiMeterS2(float x, float y) {
		Vector2 value = new(x, y);
		return new Acceleration2(value, 0.01f);
	}

	public static Acceleration2 DeciMeterS2(float x, float y) {
		Vector2 value = new(x, y);
		return new Acceleration2(value, 0.1f);
	}

	public static Acceleration2 MeterS2(float x, float y) {
		Vector2 value = new(x, y);
		return new Acceleration2(value);
	}

	public static Acceleration2 DecaMeterS2(float x, float y) {
		Vector2 value = new(x, y);
		return new Acceleration2(value, 10);
	}

	public static Acceleration2 HectoMeterS2(float x, float y) {
		Vector2 value = new(x, y);
		return new Acceleration2(value, 100);
	}

	public static Acceleration2 KiloMeterS2(float x, float y) {
		Vector2 value = new(x, y);
		return new Acceleration2(value, 1000);
	}

	public static Acceleration2 MegaMeterS2(float x, float y) {
		Vector2 value = new(x, y);
		return new Acceleration2(value, 1000000);
	}
}

public class Force2 : Value2 {
	public Force2(Vector2 value, float scale = 1) : base(value, scale) { }
	public Force2(Acceleration2 accel, Mass mass) : base(accel * mass) { }

	public static Force2 operator +(Force2 left, Force2 right) {
		return Add(left, right);
	}

	public static Force2 operator -(Force2 left, Force2 right) {
		return Sub(left, right);
	}

	public static Force2 operator *(Force2 left, Force2 right) {
		return Mul(left, right);
	}

	public static Force2 operator /(Force2 left, Force2 right) {
		return Div(left, right);
	}
}

public class Length2 : Value2 {
	public Length2(Vector2 value, float scale = 1) : base(value, scale) { }

	public static Length2 operator +(Length2 left, Velocity2 right) {
		return Add(left, right.Length2(Time.deltaTime));
	}

	public static Length2 operator -(Length2 left, Velocity2 right) {
		return Sub(left, right.Length2(Time.deltaTime));
	}

	public static Length2 operator +(Length2 left, Length2 right) {
		return Add(left, right);
	}

	public static Length2 operator -(Length2 left, Length2 right) {
		return Sub(left, right);
	}

	public static Length2 operator *(Length2 left, Length2 right) {
		return Mul(left, right);
	}

	public static Length2 operator /(Length2 left, Length2 right) {
		return Div(left, right);
	}
}

public class Velocity2 : Value2 {
	public Velocity2(Vector2 value, float scale = 1) : base(value, scale) { }

	public Velocity2(Length2 length, Time time) : base(length.value / time.value) { }

	public Length2 Length2(Time time) {
		return new Length2(value * time);
	}

	public static Velocity2 operator +(Velocity2 left, Acceleration2 right) {
		return Add(left, right.Velocity2(Time.deltaTime));
	}

	public static Velocity2 operator -(Velocity2 left, Acceleration2 right) {
		return Sub(left, right.Velocity2(Time.deltaTime));
	}

	public static Velocity2 operator +(Velocity2 left, Velocity2 right) {
		return Add(left, right);
	}

	public static Velocity2 operator -(Velocity2 left, Velocity2 right) {
		return Sub(left, right);
	}

	public static Velocity2 operator *(Velocity2 left, Velocity2 right) {
		return Mul(left, right);
	}

	public static Velocity2 operator /(Velocity2 left, Velocity2 right) {
		return Div(left, right);
	}
}

public class Acceleration2 : Value2 {
	public Acceleration2(Vector2 value, float scale = 1) : base(value, scale) { }

	public Acceleration2(Force2 force, Mass mass) : base(force.value / mass.value) { }
	
	public Velocity2 Velocity2(Time time) {
		return new Velocity2(value * time);
	}

	public static Force2 operator *(Acceleration2 left, Mass right) {
		return new Force2(left.value * right.value);
	}

	public static Force2 operator *(Mass left, Acceleration2 right) {
		return new Force2(right.value * left.value);
	}

	public static Acceleration2 operator +(Acceleration2 left, Acceleration2 right) {
		return Add(left, right);
	}

	public static Acceleration2 operator -(Acceleration2 left, Acceleration2 right) {
		return Sub(left, right);
	}

	public static Acceleration2 operator *(Acceleration2 left, Acceleration2 right) {
		return Mul(left, right);
	}

	public static Acceleration2 operator /(Acceleration2 left, Acceleration2 right) {
		return Div(left, right);
	}
}

public class Angle2 : Value2 {
	public Angle2(Vector2 value, float scale = 1) : base(value, scale) { }

	public static Angle2 operator +(Angle2 left, Angle2 right) {
		return Add(left, right);
	}

	public static Angle2 operator -(Angle2 left, Angle2 right) {
		return Sub(left, right);
	}

	public static Angle2 operator *(Angle2 left, Angle2 right) {
		return Mul(left, right);
	}

	public static Angle2 operator /(Angle2 left, Angle2 right) {
		return Div(left, right);
	}
}

public class Value2 {
	protected Value2(Vector2 value, float scale = 1) {
		this.value = value * scale;
	}

	public float sqrMagnitude => value.x*value.x + value.y*value.y;
	public float magnitude => MathF.Sqrt(sqrMagnitude);
	
	public Vector2 value { get; set; }

	public static implicit operator Vector2(Value2 v) => v.value;

	protected static T Add<T>(T left, T right) where T : Value2 {
		left.value = (Vector2)left + right;
		return left;
	}

	protected static T Sub<T>(T left, T right) where T : Value2 {
		left.value = (Vector2)left - right;
		return left;
	}

	protected static T Mul<T>(T left, T right) where T : Value2 {
		left.value = (Vector2)left * right;
		return left;
	}

	protected static T Div<T>(T left, T right) where T : Value2 {
		left.value = (Vector2)left / right;
		return left;
	}
}
}