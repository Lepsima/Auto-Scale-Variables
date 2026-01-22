using UnityEngine;
using static AutoScaleVariables.Unit;

namespace AutoScaleVariables {
[System.Serializable]
public class ForceAccelUI : ValueUI {
	public ForceAccelUIType type;
	
	public ForceAccel Value => this;
	
	public static implicit operator float(ForceAccelUI v) => v.Value; 
	
	public static implicit operator ForceAccel(ForceAccelUI v) {
		return v.type switch {
			ForceAccelUIType.NewtonSecond => NewtonSecond(v._value),
			ForceAccelUIType.KiloNewtonSecond => KiloNewtonSecond(v._value),
			_ => new ForceAccel(v._value)
		};
	}
}

[System.Serializable]
public class ForceAccel2UI : Value2UI {
	public ForceAccelUIType type;
		
	public ForceAccel2 Value => this;
	
	public static implicit operator Vector2(ForceAccel2UI v) => v.Value; 
	
	public static implicit operator ForceAccel2(ForceAccel2UI v) {
		return v.type switch {
			ForceAccelUIType.NewtonSecond => NewtonSecond(v._value),
			ForceAccelUIType.KiloNewtonSecond => KiloNewtonSecond(v._value),
			_ => new ForceAccel2(v._value)
		};
	}
}

[System.Serializable]
public class ForceAccel3UI : Value3UI {
	public ForceAccelUIType type;
	
	public ForceAccel3 Value => this;
	
	public static implicit operator Vector3(ForceAccel3UI v) => v.Value; 
	
	public static implicit operator ForceAccel3(ForceAccel3UI v) {
		return v.type switch {
			ForceAccelUIType.NewtonSecond => NewtonSecond(v._value),
			ForceAccelUIType.KiloNewtonSecond => KiloNewtonSecond(v._value),
			_ => new ForceAccel3(v._value)
		};
	}
}

public enum ForceAccelUIType {
	[InspectorName("N╱s")]
	NewtonSecond,
	
	[InspectorName("kN╱s")]
	KiloNewtonSecond,
}
}