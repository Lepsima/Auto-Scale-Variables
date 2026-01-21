using UnityEngine;

namespace AutoScaleVariables {
public class Direction2 : Value2<Magnitude> {
	public Direction2(Vector2 value, float scale = 1) : base(value, scale) { }

	public override Direction2 normalized => this;

	public override Magnitude sqrMagnitude => new(1);
	public override Magnitude magnitude => new(1);
}
}