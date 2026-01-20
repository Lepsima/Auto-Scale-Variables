using UnityEngine;

namespace AutoScaleVariables {

public static class Functions {
	public static Value Clone(this Value value) => new(value);
	public static Value2 Clone(this Value2 value) => new(value);
	public static Value3 Clone(this Value3 value) => new(value);

	public static Vector2 Normalize(this Value2 value) => value.value.normalized;
	public static Vector3 Normalize(this Value3 value) => value.value.normalized;

	public static float AsKiloMeter(this Value value) => value.value;
	//public static &1 As&2&3(this &4 value) => value.value;
}
}