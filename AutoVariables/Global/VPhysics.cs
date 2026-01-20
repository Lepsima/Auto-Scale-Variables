using UnityEngine;
using static AutoScaleVariables.Unit;

namespace AutoScaleVariables {
public static class VPhysics {
	public static Acceleration3 gravity => MeterS2(Physics.gravity);
}
}