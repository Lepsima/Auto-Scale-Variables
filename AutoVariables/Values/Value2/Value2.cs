using UnityEngine;
using System;

namespace AutoScaleVariables {
[Serializable]
public class Value2 {
	public Value2(Vector2 value, float scale = 1) => this.value = value * scale;

	[SerializeField]
	private Vector2 _value;
	
	public Vector2 value {
		get => _value;
		set => _value = value;
	}

	public Vector2 normalized => value.normalized;
	public float sqrMagnitude => value.x * value.x + value.y * value.y;
	public float magnitude => Mathf.Sqrt(sqrMagnitude);

	public float x => value.x;
	public float y => value.y;

	public static implicit operator Vector2(Value2 v) => v.value;

	protected static T Add<T>(T left, T right) where T : Value2 {
		left.value = (Vector2)left + right;
		return left;
	}

	protected static T Sub<T>(T left, T right) where T : Value2 {
		left.value = (Vector2)left - right;
		return left;
	}

	protected static T Mul<T>(T left, T right) where T : Value2 {
		left.value = (Vector2)left * right;
		return left;
	}

	protected static T Div<T>(T left, T right) where T : Value2 {
		left.value = (Vector2)left / right;
		return left;
	}
}
}