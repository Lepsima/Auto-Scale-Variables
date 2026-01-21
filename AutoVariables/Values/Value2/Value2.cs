using UnityEngine;
using System;

namespace AutoScaleVariables {
[Serializable]
public abstract class Value2<V1> where V1 : Value, new() {
	public Value2() {}
	public Value2(Vector2 value, float scale = 1) => this.value = value * scale;

	[SerializeField]
	private Vector2 _value;
	
	public Vector2 value {
		get => _value;
		set => _value = value;
	}

	public virtual Direction2 normalized => new(value.normalized);
	public virtual V1 sqrMagnitude => new() { value = value.x*value.x + value.y*value.y };
	public virtual V1 magnitude => new() { value = Mathf.Sqrt(sqrMagnitude) };
	
	public V1 x => new() {value = value.x};
	public V1 y => new() {value = value.y};

	public static implicit operator Vector2(Value2<V1> v) => v.value;

	protected static T Add<T>(T left, T right) where T : Value2<V1>, new() {
		left.value = (Vector2)left + right;
		return left;
	}

	protected static T Sub<T>(T left, T right) where T : Value2<V1>, new() {
		left.value = (Vector2)left - right;
		return left;
	}

	protected static T Mul<T>(T left, T right) where T : Value2<V1>, new() {
		left.value = (Vector2)left * right;
		return left;
	}

	protected static T Div<T>(T left, T right) where T : Value2<V1>, new() {
		left.value = (Vector2)left / right;
		return left;
	}
}
}