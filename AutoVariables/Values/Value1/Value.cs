using System;
using UnityEngine;

namespace AutoScaleVariables {
[Serializable]
public abstract class Value {
	public Value() {}
	public Value(float value, float scale = 1) => this.value = value * scale;

	[SerializeField]
	private float _value;
	
	public float value {
		get => _value;
		set => _value = value;
	}

	public static implicit operator float(Value v) => v.value;

	protected static T Add<T>(T left, T right) where T : Value {
		left.value = (float)left + right;
		return left;
	}

	protected static T Sub<T>(T left, T right) where T : Value {
		left.value = (float)left - right;
		return left;
	}

	protected static T Mul<T>(T left, T right) where T : Value {
		left.value = (float)left * right;
		return left;
	}

	protected static T Div<T>(T left, T right) where T : Value {
		left.value = (float)left / right;
		return left;
	}
}
}