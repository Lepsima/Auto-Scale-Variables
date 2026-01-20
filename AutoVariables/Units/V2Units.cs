using UnityEngine;

namespace AutoScaleVariables {
public static partial class Unit {
	
	public static Force2 MicroNewton(Vector2 value) => new(value, 0.000001f);

	public static Force2 MilliNewton(Vector2 value) => new(value, 0.001f);

	public static Force2 CentiNewton(Vector2 value) => new(value, 0.01f);

	public static Force2 DeciNewton(Vector2 value) => new(value, 0.1f);

	public static Force2 Newton(Vector2 value) => new(value);

	public static Force2 DecaNewton(Vector2 value) => new(value, 10);

	public static Force2 HectoNewton(Vector2 value) => new(value, 100);

	public static Force2 KiloNewton(Vector2 value) => new(value, 1000);

	public static Force2 MegaNewton(Vector2 value) => new(value, 1000000);

	public static Length2 MicroMeter(Vector2 value) => new(value, 0.000001f);

	public static Length2 MilliMeter(Vector2 value) => new(value, 0.001f);

	public static Length2 CentiMeter(Vector2 value) => new(value, 0.01f);

	public static Length2 DeciMeter(Vector2 value) => new(value, 0.1f);

	public static Length2 Meter(Vector2 value) => new(value);

	public static Length2 DecaMeter(Vector2 value) => new(value, 10);

	public static Length2 HectoMeter(Vector2 value) => new(value, 100);

	public static Length2 KiloMeter(Vector2 value) => new(value, 1000);

	public static Length2 MegaMeter(Vector2 value) => new(value, 1000000);

	public static Velocity2 MicroMeterSecond(Vector2 value) => new(value, 0.000001f);

	public static Velocity2 MilliMeterSecond(Vector2 value) => new(value, 0.001f);

	public static Velocity2 CentiMeterSecond(Vector2 value) => new(value, 0.01f);

	public static Velocity2 DeciMeterSecond(Vector2 value) => new(value, 0.1f);

	public static Velocity2 MeterSecond(Vector2 value) => new(value);

	public static Velocity2 DecaMeterSecond(Vector2 value) => new(value, 10);

	public static Velocity2 HectoMeterSecond(Vector2 value) => new(value, 100);

	public static Velocity2 KiloMeterSecond(Vector2 value) => new(value, 1000);

	public static Velocity2 MegaMeterSecond(Vector2 value) => new(value, 1000000);

	public static Acceleration2 MicroMeterS2(Vector2 value) => new(value, 0.000001f);

	public static Acceleration2 MilliMeterS2(Vector2 value) => new(value, 0.001f);

	public static Acceleration2 CentiMeterS2(Vector2 value) => new(value, 0.01f);

	public static Acceleration2 DeciMeterS2(Vector2 value) => new(value, 0.1f);

	public static Acceleration2 MeterS2(Vector2 value) => new(value);

	public static Acceleration2 DecaMeterS2(Vector2 value) => new(value, 10);

	public static Acceleration2 HectoMeterS2(Vector2 value) => new(value, 100);

	public static Acceleration2 KiloMeterS2(Vector2 value) => new(value, 1000);

	public static Acceleration2 MegaMeterS2(Vector2 value) => new(value, 1000000);

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
}