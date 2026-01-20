using UnityEngine;
using UnityEngine.UIElements;

namespace AutoScaleVariables {
public static class MathV {
	public static Force Clamp(Force force, float min, float	max) {
		return new Force(Mathf.Clamp(force.value, min, max));
	}
}
}