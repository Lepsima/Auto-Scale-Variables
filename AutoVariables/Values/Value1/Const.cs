using System;

namespace AutoScaleVariables {
[Serializable]
public class Const : Value {
	public Const(float value, float scale = 1) : base(value, scale) { }

	public static Const operator +(Const left, Const right) => Add(left, right);

	public static Const operator -(Const left, Const right) => Sub(left, right);

	public static Const operator *(Const left, Const right) => Mul(left, right);

	public static Const operator /(Const left, Const right) => Div(left, right);
}
}