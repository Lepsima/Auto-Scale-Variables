namespace AutoScaleVariables {
public static partial class Unit {
	
	public static Time MicroSecond(float value) => new(value, 0.000001f);

	public static Time MilliSecond(float value) => new(value, 0.001f);

	public static Time CentiSecond(float value) => new(value, 0.01f);

	public static Time DeciSecond(float value) => new(value, 0.1f);

	public static Time Second(float value) => new(value);

	public static Time DecaSecond(float value) => new(value, 10);

	public static Time HectoSecond(float value) => new(value, 100);

	public static Time KiloSecond(float value) => new(value, 1000);

	public static Time MegaSecond(float value) => new(value, 1000000);

	public static Mass MicroGram(float value) => new(value, 0.000001f);

	public static Mass MilliGram(float value) => new(value, 0.001f);

	public static Mass CentiGram(float value) => new(value, 0.01f);

	public static Mass DeciGram(float value) => new(value, 0.1f);

	public static Mass Gram(float value) => new(value);

	public static Mass DecaGram(float value) => new(value, 10);

	public static Mass HectoGram(float value) => new(value, 100);

	public static Mass KiloGram(float value) => new(value, 1000);

	public static Mass MegaGram(float value) => new(value, 1000000);

	public static Force MicroNewton(float value) => new(value, 0.000001f);

	public static Force MilliNewton(float value) => new(value, 0.001f);

	public static Force CentiNewton(float value) => new(value, 0.01f);

	public static Force DeciNewton(float value) => new(value, 0.1f);

	public static Force Newton(float value) => new(value);

	public static Force DecaNewton(float value) => new(value, 10);

	public static Force HectoNewton(float value) => new(value, 100);

	public static Force KiloNewton(float value) => new(value, 1000);

	public static Force MegaNewton(float value) => new(value, 1000000);

	public static Length MicroMeter(float value) => new(value, 0.000001f);

	public static Length MilliMeter(float value) => new(value, 0.001f);

	public static Length CentiMeter(float value) => new(value, 0.01f);

	public static Length DeciMeter(float value) => new(value, 0.1f);

	public static Length Meter(float value) => new(value);

	public static Length DecaMeter(float value) => new(value, 10);

	public static Length HectoMeter(float value) => new(value, 100);

	public static Length KiloMeter(float value) => new(value, 1000);

	public static Length MegaMeter(float value) => new(value, 1000000);

	public static Velocity MicroMeterSecond(float value) => new(value, 0.000001f);

	public static Velocity MilliMeterSecond(float value) => new(value, 0.001f);

	public static Velocity CentiMeterSecond(float value) => new(value, 0.01f);

	public static Velocity DeciMeterSecond(float value) => new(value, 0.1f);

	public static Velocity MeterSecond(float value) => new(value);

	public static Velocity DecaMeterSecond(float value) => new(value, 10);

	public static Velocity HectoMeterSecond(float value) => new(value, 100);

	public static Velocity KiloMeterSecond(float value) => new(value, 1000);

	public static Velocity MegaMeterSecond(float value) => new(value, 1000000);

	public static Acceleration MicroMeterS2(float value) => new(value, 0.000001f);

	public static Acceleration MilliMeterS2(float value) => new(value, 0.001f);

	public static Acceleration CentiMeterS2(float value) => new(value, 0.01f);

	public static Acceleration DeciMeterS2(float value) => new(value, 0.1f);

	public static Acceleration MeterS2(float value) => new(value);

	public static Acceleration DecaMeterS2(float value) => new(value, 10);

	public static Acceleration HectoMeterS2(float value) => new(value, 100);

	public static Acceleration KiloMeterS2(float value) => new(value, 1000);

	public static Acceleration MegaMeterS2(float value) => new(value, 1000000);
}
}