using UnityEngine;
using static AutoScaleVariables.Unit;

namespace AutoScaleVariables {
[System.Serializable]
public class ConstUI : ValueUI {
	public ConstUIType type;
	public Const Value => this;
	
	public static implicit operator float(ConstUI v) => v.Value.value; 
	public static implicit operator Const(ConstUI v) => new(v._value);
}

public enum ConstUIType {
	[InspectorName("Default")]
	Default,
}
}