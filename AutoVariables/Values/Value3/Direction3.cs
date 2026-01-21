using UnityEngine;

namespace AutoScaleVariables {
public class Direction3 : Value3<Magnitude> {
	public Direction3(Vector3 value, float scale = 1) : base(value, scale) { }

	public override Direction3 normalized => this;

	public override Magnitude sqrMagnitude => new(1);
	public override Magnitude magnitude => new(1);
}
}