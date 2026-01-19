using UnityEngine;

namespace AutoScaleVariables {
public abstract partial class Scales {
        public static Force2 MicroNewton(Vector2 value) => new(value, 0.000001f);
        public static Force2 MilliNewton(Vector2 value) => new(value, 0.001f);
        public static Force2 CentiNewton(Vector2 value) => new(value, 0.01f);
        public static Force2 DeciNewton(Vector2 value) => new(value, 0.1f);
        public static Force2 Newton(Vector2 value) => new(value, 1);
        public static Force2 DecaNewton(Vector2 value) => new(value, 10);
        public static Force2 HectoNewton(Vector2 value) => new(value, 100);
        public static Force2 KiloNewton(Vector2 value) => new(value, 1000);
        public static Force2 MegaNewton(Vector2 value) => new(value, 1000000);
        public static Length2 MicroMeter(Vector2 value) => new(value, 0.000001f);
        public static Length2 MilliMeter(Vector2 value) => new(value, 0.001f);
        public static Length2 CentiMeter(Vector2 value) => new(value, 0.01f);
        public static Length2 DeciMeter(Vector2 value) => new(value, 0.1f);
        public static Length2 Meter(Vector2 value) => new(value, 1);
        public static Length2 DecaMeter(Vector2 value) => new(value, 10);
        public static Length2 HectoMeter(Vector2 value) => new(value, 100);
        public static Length2 KiloMeter(Vector2 value) => new(value, 1000);
        public static Length2 MegaMeter(Vector2 value) => new(value, 1000000);
        public static Velocity2 MicroMeterSecond(Vector2 value) => new(value, 0.000001f);
        public static Velocity2 MilliMeterSecond(Vector2 value) => new(value, 0.001f);
        public static Velocity2 CentiMeterSecond(Vector2 value) => new(value, 0.01f);
        public static Velocity2 DeciMeterSecond(Vector2 value) => new(value, 0.1f);
        public static Velocity2 MeterSecond(Vector2 value) => new(value, 1);
        public static Velocity2 DecaMeterSecond(Vector2 value) => new(value, 10);
        public static Velocity2 HectoMeterSecond(Vector2 value) => new(value, 100);
        public static Velocity2 KiloMeterSecond(Vector2 value) => new(value, 1000);
        public static Velocity2 MegaMeterSecond(Vector2 value) => new(value, 1000000);
        public static Acceleration2 MicroMeterS2(Vector2 value) => new(value, 0.000001f);
        public static Acceleration2 MilliMeterS2(Vector2 value) => new(value, 0.001f);
        public static Acceleration2 CentiMeterS2(Vector2 value) => new(value, 0.01f);
        public static Acceleration2 DeciMeterS2(Vector2 value) => new(value, 0.1f);
        public static Acceleration2 MeterS2(Vector2 value) => new(value, 1);
        public static Acceleration2 DecaMeterS2(Vector2 value) => new(value, 10);
        public static Acceleration2 HectoMeterS2(Vector2 value) => new(value, 100);
        public static Acceleration2 KiloMeterS2(Vector2 value) => new(value, 1000);
        public static Acceleration2 MegaMeterS2(Vector2 value) => new(value, 1000000);

}
public class Force2 : Value2 {
        public Force2(Vector2 value, float scale = 1, int dimension = 1) : base(value, scale, dimension, Unit.Force2) { }

        public static Force2 operator +(Force2 left, Force2 right) => Add(left, right);
        public static Force2 operator -(Force2 left, Force2 right) => Sub(left, right);
        public static Force2 operator *(Force2 left, Force2 right) => Mul(left, right);
        public static Force2 operator /(Force2 left, Force2 right) => Div(left, right);
}
public class Length2 : Value2 {
        public Length2(Vector2 value, float scale = 1, int dimension = 1) : base(value, scale, dimension, Unit.Length2) { }

        public static Length2 operator +(Length2 left, Length2 right) => Add(left, right);
        public static Length2 operator -(Length2 left, Length2 right) => Sub(left, right);
        public static Length2 operator *(Length2 left, Length2 right) => Mul(left, right);
        public static Length2 operator /(Length2 left, Length2 right) => Div(left, right);
}
public class Velocity2 : Value2 {
        public Velocity2(Vector2 value, float scale = 1, int dimension = 1) : base(value, scale, dimension, Unit.Velocity2) { }

        public static Velocity2 operator +(Velocity2 left, Velocity2 right) => Add(left, right);
        public static Velocity2 operator -(Velocity2 left, Velocity2 right) => Sub(left, right);
        public static Velocity2 operator *(Velocity2 left, Velocity2 right) => Mul(left, right);
        public static Velocity2 operator /(Velocity2 left, Velocity2 right) => Div(left, right);
}
public class Acceleration2 : Value2 {
        public Acceleration2(Vector2 value, float scale = 1, int dimension = 1) : base(value, scale, dimension, Unit.Acceleration2) { }

        public static Acceleration2 operator +(Acceleration2 left, Acceleration2 right) => Add(left, right);
        public static Acceleration2 operator -(Acceleration2 left, Acceleration2 right) => Sub(left, right);
        public static Acceleration2 operator *(Acceleration2 left, Acceleration2 right) => Mul(left, right);
        public static Acceleration2 operator /(Acceleration2 left, Acceleration2 right) => Div(left, right);
}
public class Angle2 : Value2 {
        public Angle2(Vector2 value, float scale = 1, int dimension = 1) : base(value, scale, dimension, Unit.Angle2) { }

        public static Angle2 operator +(Angle2 left, Angle2 right) => Add(left, right);
        public static Angle2 operator -(Angle2 left, Angle2 right) => Sub(left, right);
        public static Angle2 operator *(Angle2 left, Angle2 right) => Mul(left, right);
        public static Angle2 operator /(Angle2 left, Angle2 right) => Div(left, right);
}

public class Value2 {
        private readonly Vector2 value;
        private readonly float scale;
        private readonly Unit unit;
        private readonly int dimension;

        protected Value2(Vector2 value, float scale = 1, int dimension = 1, Unit unit = Unit.INVALID) {
                this.value = value;
                this.scale = scale;
                this.dimension = dimension;
                this.unit = unit;
        }

        private Value2 Clone(Vector2 value) {
                return new Value2(value, scale, dimension, unit);
        }

        private Vector2 GetValue() {
                return value * scale;
        }

        private bool Compatible(Value2 other) {
                return unit == other.unit;
        }

        protected static T Add<T>(T left, T right) where T : Value2{
                if (!right.Compatible(left)) throw new UnitException(right.unit + " is not compatible with " + left.unit);
                Vector2 val = left.GetValue() + right.GetValue();
                return (T)left.Clone(val);
        }

        protected static T Sub<T>(T left, T right) where T : Value2{
                if (!right.Compatible(left)) throw new UnitException(right.unit + " is not compatible with " + left.unit);
                Vector2 val = left.GetValue() - right.GetValue();
                return (T)left.Clone(val);
        }

        protected static T Mul<T>(T left, T right) where T : Value2{
                if (!right.Compatible(left)) throw new UnitException(right.unit + " is not compatible with " + left.unit);
                Vector2 val = left.GetValue() * right.GetValue();
                return (T)left.Clone(val);
        }

        protected static T Div<T>(T left, T right) where T : Value2{
                if (!right.Compatible(left)) throw new UnitException(right.unit + " is not compatible with " + left.unit);
                Vector2 val = left.GetValue() / right.GetValue();
                return (T)left.Clone(val);
        }
}
}