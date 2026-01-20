namespace AutoScaleVariables {
public class Angle : Value {
	public Angle(float value, float scale = 1) : base(value, scale) { }

	public static Angle operator +(Angle left, Angle right) => Add(left, right);

	public static Angle operator -(Angle left, Angle right) => Sub(left, right);

	public static Angle operator *(Angle left, Angle right) => Mul(left, right);

	public static Angle operator /(Angle left, Angle right) => Div(left, right);
}
}