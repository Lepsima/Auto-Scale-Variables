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
	public virtual V1 sqrMagnitude => new() { value = value.sqrMagnitude };
	public virtual V1 magnitude => new() { value = value.magnitude };
	
	public V1 x => new() {value = value.x};
	public V1 y => new() {value = value.y};

	public static implicit operator Vector2(Value2<V1> v) => v.value;

	protected static T Add<T>(T left, T right) where T : Value2<V1>, new() {
		return new T { value = (Vector2)left + right };
	}

	protected static T Sub<T>(T left, T right) where T : Value2<V1>, new() {
		return new T { value = (Vector2)left - right };

	}

	protected static T Mul<T>(T left, T right) where T : Value2<V1>, new() {
		return new T { value = (Vector2)left * right };

	}

	protected static T Div<T>(T left, T right) where T : Value2<V1>, new() {
		return new T { value = (Vector2)left / right };

	}
}
}