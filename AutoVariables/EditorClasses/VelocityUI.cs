using UnityEngine;
using static AutoScaleVariables.Unit;

namespace AutoScaleVariables {
[System.Serializable]
public class VelocityUI : ValueUI {
	public VelocityUIType type;
	
	public Velocity Value => this;
	
	public static implicit operator float(VelocityUI v) => v.Value; 
	
	public static implicit operator Velocity(VelocityUI v) {
		return v.type switch {
			VelocityUIType.MeterSecond => MeterSecond(v._value),
			VelocityUIType.KilometerHour => KilometerHour(v._value),
			VelocityUIType.FeetSecond => FeetSecond(v._value),
			VelocityUIType.MilesHour => MileHour(v._value),
			_ => new Velocity(v._value)
		};
	}
}

[System.Serializable]
public class Velocity2UI : Value2UI {
	public VelocityUIType type;
		
	public Velocity2 Value => this;
	
	public static implicit operator Vector2(Velocity2UI v) => v.Value; 
	
	public static implicit operator Velocity2(Velocity2UI v) {
		return v.type switch {
			VelocityUIType.MeterSecond => MeterSecond(v._value),
			VelocityUIType.KilometerHour => KilometerHour(v._value),
			VelocityUIType.FeetSecond => FeetSecond(v._value),
			VelocityUIType.MilesHour => MileHour(v._value),
			_ => new Velocity2(v._value)
		};
	}
}

[System.Serializable]
public class Velocity3UI : Value3UI {
	public VelocityUIType type;
	
	public Velocity3 Value => this;
	
	public static implicit operator Vector3(Velocity3UI v) => v.Value; 
	
	public static implicit operator Velocity3(Velocity3UI v) {
		return v.type switch {
			VelocityUIType.MeterSecond => MeterSecond(v._value),
			VelocityUIType.KilometerHour => KilometerHour(v._value),
			VelocityUIType.FeetSecond => FeetSecond(v._value),
			VelocityUIType.MilesHour => MileHour(v._value),
			_ => new Velocity3(v._value)
		};
	}
}

public enum VelocityUIType {
	[InspectorName("m╱s")]
	MeterSecond,
	
	[InspectorName("km╱h")]
	KilometerHour,
	
	[InspectorName("ft╱s")]
	FeetSecond,
	
	[InspectorName("mi╱h")]
	MilesHour,
}
}