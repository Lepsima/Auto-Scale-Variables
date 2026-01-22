using UnityEngine;
using static AutoScaleVariables.Unit;
using System;

namespace AutoScaleVariables {
[Serializable]
public class ForceUI : ValueUI {
	public ForceUIType type;
	
	public Force Value => this;
	
	public static implicit operator float(ForceUI v) => v.Value; 
	
	public static implicit operator Force(ForceUI v) {
		return v.type switch {
			ForceUIType.Newton => Newton(v._value),
			ForceUIType.KiloNewton => KiloNewton(v._value),
			_ => new Force(v._value)
		};
	}
}

[Serializable]
public class Force2UI : Value2UI {
	public ForceUIType type;
		
	public Force2 Value => this;
	
	public static implicit operator Vector2(Force2UI v) => v.Value; 
	
	public static implicit operator Force2(Force2UI v) {
		return v.type switch {
			ForceUIType.Newton => Newton(v._value),
			ForceUIType.KiloNewton => KiloNewton(v._value),
			_ => new Force2(v._value)
		};
	}
}

[Serializable]
public class Force3UI : Value3UI {
	public ForceUIType type;
	
	public Force3 Value => this;
	
	public static implicit operator Vector3(Force3UI v) => v.Value; 
	
	public static implicit operator Force3(Force3UI v) {
		return v.type switch {
			ForceUIType.Newton => Newton(v._value),
			ForceUIType.KiloNewton => KiloNewton(v._value),
			_ => new Force3(v._value)
		};
	}
}

public enum ForceUIType {
	[InspectorName("N")]
	Newton,
	
	[InspectorName("kN")]
	KiloNewton,
}
}