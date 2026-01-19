using UnityEngine;
using static AutoScaleVariables.Scales;

namespace AutoScaleVariables {
public abstract partial class Scales {
	public static Force3 MicroNewton(Vector3 value) {
		return new Force3(value, 0.000001f);
	}

	public static Force3 MilliNewton(Vector3 value) {
		return new Force3(value, 0.001f);
	}

	public static Force3 CentiNewton(Vector3 value) {
		return new Force3(value, 0.01f);
	}

	public static Force3 DeciNewton(Vector3 value) {
		return new Force3(value, 0.1f);
	}

	public static Force3 Newton(Vector3 value) {
		return new Force3(value);
	}

	public static Force3 DecaNewton(Vector3 value) {
		return new Force3(value, 10);
	}

	public static Force3 HectoNewton(Vector3 value) {
		return new Force3(value, 100);
	}

	public static Force3 KiloNewton(Vector3 value) {
		return new Force3(value, 1000);
	}

	public static Force3 MegaNewton(Vector3 value) {
		return new Force3(value, 1000000);
	}

	public static Length3 MicroMeter(Vector3 value) {
		return new Length3(value, 0.000001f);
	}

	public static Length3 MilliMeter(Vector3 value) {
		return new Length3(value, 0.001f);
	}

	public static Length3 CentiMeter(Vector3 value) {
		return new Length3(value, 0.01f);
	}

	public static Length3 DeciMeter(Vector3 value) {
		return new Length3(value, 0.1f);
	}

	public static Length3 Meter(Vector3 value) {
		return new Length3(value);
	}

	public static Length3 DecaMeter(Vector3 value) {
		return new Length3(value, 10);
	}

	public static Length3 HectoMeter(Vector3 value) {
		return new Length3(value, 100);
	}

	public static Length3 KiloMeter(Vector3 value) {
		return new Length3(value, 1000);
	}

	public static Length3 MegaMeter(Vector3 value) {
		return new Length3(value, 1000000);
	}

	public static Velocity3 MicroMeterSecond(Vector3 value) {
		return new Velocity3(value, 0.000001f);
	}

	public static Velocity3 MilliMeterSecond(Vector3 value) {
		return new Velocity3(value, 0.001f);
	}

	public static Velocity3 CentiMeterSecond(Vector3 value) {
		return new Velocity3(value, 0.01f);
	}

	public static Velocity3 DeciMeterSecond(Vector3 value) {
		return new Velocity3(value, 0.1f);
	}

	public static Velocity3 MeterSecond(Vector3 value) {
		return new Velocity3(value);
	}

	public static Velocity3 DecaMeterSecond(Vector3 value) {
		return new Velocity3(value, 10);
	}

	public static Velocity3 HectoMeterSecond(Vector3 value) {
		return new Velocity3(value, 100);
	}

	public static Velocity3 KiloMeterSecond(Vector3 value) {
		return new Velocity3(value, 1000);
	}

	public static Velocity3 MegaMeterSecond(Vector3 value) {
		return new Velocity3(value, 1000000);
	}

	public static Acceleration3 MicroMeterS2(Vector3 value) {
		return new Acceleration3(value, 0.000001f);
	}

	public static Acceleration3 MilliMeterS2(Vector3 value) {
		return new Acceleration3(value, 0.001f);
	}

	public static Acceleration3 CentiMeterS2(Vector3 value) {
		return new Acceleration3(value, 0.01f);
	}

	public static Acceleration3 DeciMeterS2(Vector3 value) {
		return new Acceleration3(value, 0.1f);
	}

	public static Acceleration3 MeterS2(Vector3 value) {
		return new Acceleration3(value);
	}

	public static Acceleration3 DecaMeterS2(Vector3 value) {
		return new Acceleration3(value, 10);
	}

	public static Acceleration3 HectoMeterS2(Vector3 value) {
		return new Acceleration3(value, 100);
	}

	public static Acceleration3 KiloMeterS2(Vector3 value) {
		return new Acceleration3(value, 1000);
	}

	public static Acceleration3 MegaMeterS2(Vector3 value) {
		return new Acceleration3(value, 1000000);
	}

	public static Force3 MicroNewton(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Force3(value, 0.000001f);
	}

	public static Force3 MilliNewton(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Force3(value, 0.001f);
	}

	public static Force3 CentiNewton(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Force3(value, 0.01f);
	}

	public static Force3 DeciNewton(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Force3(value, 0.1f);
	}

	public static Force3 Newton(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Force3(value);
	}

	public static Force3 DecaNewton(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Force3(value, 10);
	}

	public static Force3 HectoNewton(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Force3(value, 100);
	}

	public static Force3 KiloNewton(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Force3(value, 1000);
	}

	public static Force3 MegaNewton(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Force3(value, 1000000);
	}

	public static Length3 MicroMeter(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Length3(value, 0.000001f);
	}

	public static Length3 MilliMeter(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Length3(value, 0.001f);
	}

	public static Length3 CentiMeter(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Length3(value, 0.01f);
	}

	public static Length3 DeciMeter(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Length3(value, 0.1f);
	}

	public static Length3 Meter(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Length3(value);
	}

	public static Length3 DecaMeter(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Length3(value, 10);
	}

	public static Length3 HectoMeter(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Length3(value, 100);
	}

	public static Length3 KiloMeter(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Length3(value, 1000);
	}

	public static Length3 MegaMeter(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Length3(value, 1000000);
	}

	public static Velocity3 MicroMeterSecond(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Velocity3(value, 0.000001f);
	}

	public static Velocity3 MilliMeterSecond(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Velocity3(value, 0.001f);
	}

	public static Velocity3 CentiMeterSecond(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Velocity3(value, 0.01f);
	}

	public static Velocity3 DeciMeterSecond(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Velocity3(value, 0.1f);
	}

	public static Velocity3 MeterSecond(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Velocity3(value);
	}

	public static Velocity3 DecaMeterSecond(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Velocity3(value, 10);
	}

	public static Velocity3 HectoMeterSecond(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Velocity3(value, 100);
	}

	public static Velocity3 KiloMeterSecond(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Velocity3(value, 1000);
	}

	public static Velocity3 MegaMeterSecond(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Velocity3(value, 1000000);
	}

	public static Acceleration3 MicroMeterS2(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Acceleration3(value, 0.000001f);
	}

	public static Acceleration3 MilliMeterS2(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Acceleration3(value, 0.001f);
	}

	public static Acceleration3 CentiMeterS2(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Acceleration3(value, 0.01f);
	}

	public static Acceleration3 DeciMeterS2(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Acceleration3(value, 0.1f);
	}

	public static Acceleration3 MeterS2(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Acceleration3(value);
	}

	public static Acceleration3 DecaMeterS2(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Acceleration3(value, 10);
	}

	public static Acceleration3 HectoMeterS2(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Acceleration3(value, 100);
	}

	public static Acceleration3 KiloMeterS2(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Acceleration3(value, 1000);
	}

	public static Acceleration3 MegaMeterS2(float x, float y, float z) {
		Vector3 value = new(x, y, z);
		return new Acceleration3(value, 1000000);
	}
}

public class Force3 : Value3 {
	public Force3(Acceleration3 accel, Mass mass) : base(accel * mass) { }

	public Force3(Vector3 value, float scale = 1) : base(value, scale) { }

	public static Force3 operator +(Force3 left, Force3 right) {
		return Add(left, right);
	}

	public static Force3 operator -(Force3 left, Force3 right) {
		return Sub(left, right);
	}
}

public class Length3 : Value3 {
	public Length3(Vector3 value, float scale = 1) : base(value, scale) { }

	public static Length3 operator +(Length3 left, Length3 right) {
		return Add(left, right);
	}

	public static Length3 operator -(Length3 left, Length3 right) {
		return Sub(left, right);
	}
}

public class Velocity3 : Value3 {
	public Velocity3(Vector3 value, float scale = 1) : base(value, scale) { }

	public static Velocity3 operator +(Velocity3 left, Velocity3 right) {
		return Add(left, right);
	}

	public static Velocity3 operator -(Velocity3 left, Velocity3 right) {
		return Sub(left, right);
	}
}

public class Acceleration3 : Value3 {
	public Acceleration3(Vector3 value, float scale = 1) : base(value, scale) { }

	public static Force3 operator *(Acceleration3 left, Mass right) {
		return new Force3(left.value * right.value);
	}

	public static Force3 operator *(Mass left, Acceleration3 right) {
		return new Force3(right.value * left.value);
	}

	public static Acceleration3 operator +(Acceleration3 left, Acceleration3 right) {
		return Add(left, right);
	}

	public static Acceleration3 operator -(Acceleration3 left, Acceleration3 right) {
		return Sub(left, right);
	}
}

public class Angle3 : Value3 {
	public Angle3(Vector3 value, float scale = 1) : base(value, scale) { }

	public static Angle3 operator +(Angle3 left, Angle3 right) {
		return Add(left, right);
	}

	public static Angle3 operator -(Angle3 left, Angle3 right) {
		return Sub(left, right);
	}
}

public class Value3 {
	protected Value3(Vector3 value, float scale = 1) {
		this.value = value * scale;
	}

	public Vector3 value { get; set; }

	public static implicit operator Vector3(Value3 v) => v.value;

	protected static T Add<T>(T left, T right) where T : Value3 {
		left.value = (Vector3)left + right;
		return left;
	}

	protected static T Sub<T>(T left, T right) where T : Value3 {
		left.value = (Vector3)left - right;
		return left;
	}

	protected static T Mul<T>(T left, T right) where T : Value3 {
		left.value = (Vector3)left * right;
		return left;
	}

	protected static T Div<T>(T left, T right) where T : Value3 {
		left.value = (Vector3)left / right;
		return left;
	}
}
}