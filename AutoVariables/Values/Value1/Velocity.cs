namespace AutoScaleVariables {
public class Velocity : Value {
	public Velocity(float value, float scale = 1) : base(value, scale) { }

	public Velocity(Length length, Time time) : base(length.value / time.value) { }

	public Length Length(Time time) => new(value * time);

	public static Velocity operator +(Velocity left, Acceleration right) => Add(left, right.Velocity(Time.deltaTime));

	public static Velocity operator -(Velocity left, Acceleration right) => Sub(left, right.Velocity(Time.deltaTime));

	public static Velocity operator +(Velocity left, Velocity right) => Add(left, right);

	public static Velocity operator -(Velocity left, Velocity right) => Sub(left, right);

	public static Velocity operator *(Velocity left, Velocity right) => Mul(left, right);

	public static Velocity operator /(Velocity left, Velocity right) => Div(left, right);
}
}