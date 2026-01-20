namespace AutoScaleVariables {
public class Time : Value {
	private static readonly Time _static = Unit.Second(0);

	public Time(float value, float scale = 1) : base(value, scale) { }

	public static Time deltaTime {
		get {
			_static.value = UnityEngine.Time.deltaTime;
			return _static;
		}
	}

	public static Time time {
		get {
			_static.value = UnityEngine.Time.time;
			return _static;
		}
	}

	public static Time operator +(Time left, Time right) => Add(left, right);

	public static Time operator -(Time left, Time right) => Sub(left, right);

	public static Time operator *(Time left, Time right) => Mul(left, right);

	public static Time operator /(Time left, Time right) => Div(left, right);
}
}