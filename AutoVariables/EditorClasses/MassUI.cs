using System;
using UnityEngine;
using static AutoScaleVariables.Unit;

namespace AutoScaleVariables {
[System.Serializable]
public class MassUI : ValueUI {
	public MassUIType type;
	
	public Mass Value => this;
	
	public static implicit operator float(MassUI v) => v.Value; 
	
	public static implicit operator Mass(MassUI v) {
		return v.type switch {
			MassUIType.Kilogram => KiloGram(v._value),
			MassUIType.Gram => Gram(v._value),
			MassUIType.Ton => Ton(v._value),
			_ => new Mass(v._value)
		};
	}
}

public enum MassUIType {
	[InspectorName("kg")]
	Kilogram,
	
	[InspectorName("g")]
	Gram,
	
	[InspectorName("Ton")]
	Ton,
}
}