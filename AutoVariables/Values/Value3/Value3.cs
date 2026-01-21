using UnityEngine;
using System;

namespace AutoScaleVariables {
[Serializable]
public class Value3 {
	public Value3(Vector3 value, float scale = 1) => this.value = value * scale;

	[SerializeField]
	private Vector3 _value;

	public Vector3 value {
		get => _value;
		set => _value = value;
	}

	public Vector3 normalized => value.normalized;
	public float sqrMagnitude => value.x * value.x + value.y * value.y + value.z * value.z;
	public float magnitude => Mathf.Sqrt(sqrMagnitude);

	public float x => value.x;
	public float y => value.y;
	public float z => value.z;

	public void Normalize() {
		value = value.normalized;
	}

	public static implicit operator Vector3(Value3 v) => v.value;

	protected static T Add<T>(T left, T right) where T : Value3 {
		left.value = (Vector3)left + right;
		return left;
	}

	protected static T Sub<T>(T left, T right) where T : Value3 {
		left.value = (Vector3)left - right;
		return left;
	}
}
}