using UnityEngine;
using static AutoScaleVariables.Scales;

namespace AutoScaleVariables {
public static class VTime {
	public static Time deltaTime => Time.deltaTime;
	public static Time time => Time.time;
}

public static class VPhysics {
	public static Acceleration3 gravity => MeterS2(Physics.gravity);
}
}