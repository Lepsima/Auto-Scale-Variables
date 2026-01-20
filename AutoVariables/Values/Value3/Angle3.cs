using UnityEngine;

namespace AutoScaleVariables {
public class Angle3 : Value3 {
	public Angle3(Vector3 value, float scale = 1) : base(value, scale) { }
	
	public static Angle3 operator +(Angle3 left, Angle3 right) => Add(left, right);

	public static Angle3 operator -(Angle3 left, Angle3 right) => Sub(left, right);
}
}