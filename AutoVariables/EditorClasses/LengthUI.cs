using System;
using UnityEngine;
using static AutoScaleVariables.Unit;

namespace AutoScaleVariables {
[Serializable]
public class LengthUI : ValueUI {
	public LengthUIType type;

	public Length Value => this;
	
	public static implicit operator float(LengthUI v) => v.Value; 
	
	public static implicit operator Length(LengthUI v) {
		return v.type switch {
			LengthUIType.Millimeter => MilliMeter(v._value),
			LengthUIType.Centimeter => CentiMeter(v._value),
			LengthUIType.Meter => Meter(v._value),
			LengthUIType.Kilometer => KiloMeter(v._value),
			LengthUIType.Feet => Feet(v._value),
			LengthUIType.Mile => Mile(v._value),
			_ => new Length(v._value)
		};
	}
}

[Serializable]
public class Length2UI : Value2UI {
	public LengthUIType type;
	
	public Length2 Value => this;
	
	public static implicit operator Vector2(Length2UI v) => v.Value;
	
	public static implicit operator Length2(Length2UI v) {
		return v.type switch {
			LengthUIType.Millimeter => MilliMeter(v._value),
			LengthUIType.Centimeter => CentiMeter(v._value),
			LengthUIType.Meter => Meter(v._value),
			LengthUIType.Kilometer => KiloMeter(v._value),
			LengthUIType.Feet => Feet(v._value),
			LengthUIType.Mile => Mile(v._value),
			_ => new Length2(v._value)
		};
	}
}

[Serializable]
public class Length3UI : Value3UI {
	public LengthUIType type;
	
	public Length3 Value => this;
	
	public static implicit operator Vector3(Length3UI v) => v.Value; 
	
	public static implicit operator Length3(Length3UI v) {
		return v.type switch {
			LengthUIType.Millimeter => MilliMeter(v._value),
			LengthUIType.Centimeter => CentiMeter(v._value),
			LengthUIType.Meter => Meter(v._value),
			LengthUIType.Kilometer => KiloMeter(v._value),
			LengthUIType.Feet => Feet(v._value),
			LengthUIType.Mile => Mile(v._value),
			_ => new Length3(v._value)
		};
	}
}

public enum LengthUIType {
	[InspectorName("mm")] Millimeter,
	[InspectorName("cm")] Centimeter,
	[InspectorName("m")]  Meter,
	[InspectorName("km")] Kilometer,
	[InspectorName("ft")] Feet,
	[InspectorName("mi")] Mile,
}
}