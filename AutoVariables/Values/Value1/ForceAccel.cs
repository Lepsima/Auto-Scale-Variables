using System;

namespace AutoScaleVariables {
[Serializable]
public class ForceAccel : Value {
	public ForceAccel(float value, float scale = 1) : base(value, scale) { }
	public ForceAccel(Force force, Time time) : base(force.value / time.value) { }

	public ForceAccel() { }

	public Force Force(Time time) => new(value * time);

	public static Force operator +(Force left, ForceAccel right) => Add(left, right.Force(Time.deltaTime));

	public static Force operator -(Force left, ForceAccel right) => Sub(left, right.Force(Time.deltaTime));

	public static ForceAccel operator +(ForceAccel left, ForceAccel right) => Add(left, right);

	public static ForceAccel operator -(ForceAccel left, ForceAccel right) => Sub(left, right);

	public static ForceAccel operator *(ForceAccel left, ForceAccel right) => Mul(left, right);

	public static ForceAccel operator /(ForceAccel left, ForceAccel right) => Div(left, right);
}
}