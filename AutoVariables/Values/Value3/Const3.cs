using System;
using UnityEngine;

namespace AutoScaleVariables {
[Serializable]
public class Const3 : Value3 {
	public Const3(Vector3 value, float scale = 1) : base(value, scale) { }

	public static Const3 operator +(Const3 left, Const3 right) => Add(left, right);

	public static Const3 operator -(Const3 left, Const3 right) => Sub(left, right);
}
}