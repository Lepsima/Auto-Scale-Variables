using UnityEngine;
using static AutoScaleVariables.Unit;

namespace AutoScaleVariables {
[System.Serializable]
public class AngleUI : ValueUI {
	public AngleUIType type;
	
	public Angle Value => this;
	
	public static implicit operator float(AngleUI v) => v.Value; 
	
	public static implicit operator Angle(AngleUI v) {
		return v.type switch {
			AngleUIType.Degree => Degree(v._value),
			AngleUIType.Radians => Radian(v._value),
			_ => new Angle(v._value)
		};
	}
}

[System.Serializable]
public class Angle2UI : Value2UI {
	public AngleUIType type;
		
	public Angle2 Value => this;
	
	public static implicit operator Vector2(Angle2UI v) => v.Value; 
	
	public static implicit operator Angle2(Angle2UI v) {
		return v.type switch {
			AngleUIType.Degree => Degree(v._value),
			AngleUIType.Radians => Radian(v._value),
			_ => new Angle2(v._value)
		};
	}
}

[System.Serializable]
public class Angle3UI : Value3UI {
	public AngleUIType type;
	
	public Angle3 Value => this;
	
	public static implicit operator Vector3(Angle3UI v) => v.Value; 
	
	public static implicit operator Angle3(Angle3UI v) {
		return v.type switch {
			AngleUIType.Degree => Degree(v._value),
			AngleUIType.Radians => Radian(v._value),
			_ => new Angle3(v._value)
		};
	}
}

public enum AngleUIType {
	[InspectorName("deg")]
	Degree,
	
	[InspectorName("rad")]
	Radians,
}
}