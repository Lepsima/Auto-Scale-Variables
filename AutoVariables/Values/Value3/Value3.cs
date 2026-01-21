using UnityEngine;
using System;

namespace AutoScaleVariables {
[Serializable]
public abstract class Value3<V1> where V1 : Value, new() {
	public Value3() { }
	public Value3(Vector3 value, float scale = 1) => this.value = value * scale;

	[SerializeField] private Vector3 _value;

	public Vector3 value {
		get => _value;
		set => _value = value;
	}

	public virtual Direction3 normalized => new(value.normalized);
	public virtual V1 sqrMagnitude => new() { value = value.x * value.x + value.y * value.y };
	public virtual V1 magnitude => new() { value = Mathf.Sqrt(sqrMagnitude) };

	public V1 x => new() { value = value.x };
	public V1 y => new() { value = value.y };
	public V1 z => new() { value = value.z };

	private Vector3 Mult(Vector3 other) => new(value.x * other.x, value.y * other.y, value.z * other.z);
	private Vector3 Divide(Vector3 other) => new(value.x / other.x, value.y / other.y, value.z / other.z);

	public static implicit operator Vector3(Value3<V1> v) => v.value;

	protected static T Add<T>(T left, T right) where T : Value3<V1>, new() {
		return new T { value = (Vector3)left + right };
	}

	protected static T Sub<T>(T left, T right) where T : Value3<V1>, new() {
		return new T { value = (Vector3)left + right };
	}

	protected static T Mul<T>(T l, T r) where T : Value3<V1>, new() {
		return new T { value = l.Mult(r.value) };
	}

	protected static T Div<T>(T l, T r) where T : Value3<V1>, new() {
		return new T { value = l.Divide(r.value) };
	}
}
}