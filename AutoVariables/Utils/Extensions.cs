using UnityEditor;
using UnityEngine;

namespace AutoScaleVariables {
public static class Extensions {
	public static Direction3 forward(this Transform tr) {
		return new Direction3(tr.forward);
	}
	
	public static Direction3 right(this Transform tr) {
		return new Direction3(tr.right);
	}
	
	public static Direction3 up(this Transform tr) {
		return new Direction3(tr.up);
	}

	public static Length3 position(this Transform tr) {
		return new Length3(tr.position);
	} 
	
	public static Length3 localPosition(this Transform tr) {
		return new Length3(tr.position);
	}

	public static Angle3 eulerAngles(this Transform tr) {
		return new Angle3(tr.eulerAngles);
	}
	
	public static Angle3 localEulerAngles(this Transform tr) {
		return new Angle3(tr.localEulerAngles);
	}

	public static void Apply(this Transform tr, Velocity3 velocity) {
		tr.Translate(velocity.Length3(Time.deltaTime));
	}
	
	public static void Apply(this Transform tr, Angle3 angles) {
		tr.localRotation *= Quaternion.Euler(angles);
	}
}
}