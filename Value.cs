using UnityEngine;

namespace AutoScaleVariables {
public abstract partial class Scales {
        public static Angle Degree(float value) => new(value);
        public static Angle MinuteDegree(float value) => new(value, 0.016666666666666666f);
        public static Angle SecondDegree(float value) => new(value, 0.0002777777777777778f);
        public static Angle Radian(float value) => new(value, 0.01745329238474369f);
        public static Angle Turn(float value) => new(value, 360);

        public static Mass Ton(float value) => MegaGram(value);
        
        public static Time MicroSecond(float value) => new(value, 0.000001f);
        public static Time MilliSecond(float value) => new(value, 0.001f);
        public static Time CentiSecond(float value) => new(value, 0.01f);
        public static Time DeciSecond(float value) => new(value, 0.1f);
        public static Time Second(float value) => new(value, 1);
        public static Time DecaSecond(float value) => new(value, 10);
        public static Time HectoSecond(float value) => new(value, 100);
        public static Time KiloSecond(float value) => new(value, 1000);
        public static Time MegaSecond(float value) => new(value, 1000000);
        public static Mass MicroGram(float value) => new(value, 0.000001f);
        public static Mass MilliGram(float value) => new(value, 0.001f);
        public static Mass CentiGram(float value) => new(value, 0.01f);
        public static Mass DeciGram(float value) => new(value, 0.1f);
        public static Mass Gram(float value) => new(value, 1);
        public static Mass DecaGram(float value) => new(value, 10);
        public static Mass HectoGram(float value) => new(value, 100);
        public static Mass KiloGram(float value) => new(value, 1000);
        public static Mass MegaGram(float value) => new(value, 1000000);
        public static Force MicroNewton(float value) => new(value, 0.000001f);
        public static Force MilliNewton(float value) => new(value, 0.001f);
        public static Force CentiNewton(float value) => new(value, 0.01f);
        public static Force DeciNewton(float value) => new(value, 0.1f);
        public static Force Newton(float value) => new(value, 1);
        public static Force DecaNewton(float value) => new(value, 10);
        public static Force HectoNewton(float value) => new(value, 100);
        public static Force KiloNewton(float value) => new(value, 1000);
        public static Force MegaNewton(float value) => new(value, 1000000);
        public static Length MicroMeter(float value) => new(value, 0.000001f);
        public static Length MilliMeter(float value) => new(value, 0.001f);
        public static Length CentiMeter(float value) => new(value, 0.01f);
        public static Length DeciMeter(float value) => new(value, 0.1f);
        public static Length Meter(float value) => new(value, 1);
        public static Length DecaMeter(float value) => new(value, 10);
        public static Length HectoMeter(float value) => new(value, 100);
        public static Length KiloMeter(float value) => new(value, 1000);
        public static Length MegaMeter(float value) => new(value, 1000000);
        public static Velocity MicroMeterSecond(float value) => new(value, 0.000001f);
        public static Velocity MilliMeterSecond(float value) => new(value, 0.001f);
        public static Velocity CentiMeterSecond(float value) => new(value, 0.01f);
        public static Velocity DeciMeterSecond(float value) => new(value, 0.1f);
        public static Velocity MeterSecond(float value) => new(value, 1);
        public static Velocity DecaMeterSecond(float value) => new(value, 10);
        public static Velocity HectoMeterSecond(float value) => new(value, 100);
        public static Velocity KiloMeterSecond(float value) => new(value, 1000);
        public static Velocity MegaMeterSecond(float value) => new(value, 1000000);
        public static Acceleration MicroMeterS2(float value) => new(value, 0.000001f);
        public static Acceleration MilliMeterS2(float value) => new(value, 0.001f);
        public static Acceleration CentiMeterS2(float value) => new(value, 0.01f);
        public static Acceleration DeciMeterS2(float value) => new(value, 0.1f);
        public static Acceleration MeterS2(float value) => new(value, 1);
        public static Acceleration DecaMeterS2(float value) => new(value, 10);
        public static Acceleration HectoMeterS2(float value) => new(value, 100);
        public static Acceleration KiloMeterS2(float value) => new(value, 1000);
        public static Acceleration MegaMeterS2(float value) => new(value, 1000000);
}
public class Time : Value {
        public Time(float value, float scale = 1, int dimension = 1) : base(value, scale, dimension, Unit.Time) { }

        public static Time operator +(Time left, Time right) => Add(left, right);
        public static Time operator -(Time left, Time right) => Sub(left, right);
        public static Time operator *(Time left, Time right) => Mul(left, right);
        public static Time operator /(Time left, Time right) => Div(left, right);
}
public class Mass : Value {
        public Mass(float value, float scale = 1, int dimension = 1) : base(value, scale, dimension, Unit.Mass) { }

        public static Mass operator +(Mass left, Mass right) => Add(left, right);
        public static Mass operator -(Mass left, Mass right) => Sub(left, right);
        public static Mass operator *(Mass left, Mass right) => Mul(left, right);
        public static Mass operator /(Mass left, Mass right) => Div(left, right);
}
public class Force : Value {
        public Force(float value, float scale = 1, int dimension = 1) : base(value, scale, dimension, Unit.Force) { }

        public static Force operator +(Force left, Force right) => Add(left, right);
        public static Force operator -(Force left, Force right) => Sub(left, right);
        public static Force operator *(Force left, Force right) => Mul(left, right);
        public static Force operator /(Force left, Force right) => Div(left, right);
}
public class Length : Value {
        public Length(float value, float scale = 1, int dimension = 1) : base(value, scale, dimension, Unit.Length) { }

        public static Length operator +(Length left, Length right) => Add(left, right);
        public static Length operator -(Length left, Length right) => Sub(left, right);
        public static Length operator *(Length left, Length right) => Mul(left, right);
        public static Length operator /(Length left, Length right) => Div(left, right);
}
public class Velocity : Value {
        public Velocity(float value, float scale = 1, int dimension = 1) : base(value, scale, dimension, Unit.Velocity) { }

        public static Velocity operator +(Velocity left, Velocity right) => Add(left, right);
        public static Velocity operator -(Velocity left, Velocity right) => Sub(left, right);
        public static Velocity operator *(Velocity left, Velocity right) => Mul(left, right);
        public static Velocity operator /(Velocity left, Velocity right) => Div(left, right);
}
public class Acceleration : Value {
        public Acceleration(float value, float scale = 1, int dimension = 1) : base(value, scale, dimension, Unit.Acceleration) { }

        public static Acceleration operator +(Acceleration left, Acceleration right) => Add(left, right);
        public static Acceleration operator -(Acceleration left, Acceleration right) => Sub(left, right);
        public static Acceleration operator *(Acceleration left, Acceleration right) => Mul(left, right);
        public static Acceleration operator /(Acceleration left, Acceleration right) => Div(left, right);
}
public class Angle : Value {
        public Angle(float value, float scale = 1, int dimension = 1) : base(value, scale, dimension, Unit.Angle) { }

        public static Angle operator +(Angle left, Angle right) => Add(left, right);
        public static Angle operator -(Angle left, Angle right) => Sub(left, right);
        public static Angle operator *(Angle left, Angle right) => Mul(left, right);
        public static Angle operator /(Angle left, Angle right) => Div(left, right);
}

public class Value {
        private readonly float value;
        private readonly float scale;
        private readonly Unit unit;
        private readonly int dimension;

        protected Value(float value, float scale = 1, int dimension = 1, Unit unit = Unit.INVALID) {
                this.value = value;
                this.scale = scale;
                this.dimension = dimension;
                this.unit = unit;
        }

        private Value Clone(float value) {
                return new Value(value, scale, dimension, unit);
        }

        private float GetValue() {
                return Dimension.Apply(value * scale, dimension);
        }

        private bool Compatible(Value other) {
                return unit == other.unit;
        }

        protected static T Add<T>(T left, T right) where T : Value{
                if (!right.Compatible(left)) throw new UnitException(right.unit + " is not compatible with " + left.unit);
                float val = left.GetValue() + right.GetValue();
                return (T)left.Clone(val);
        }

        protected static T Sub<T>(T left, T right) where T : Value{
                if (!right.Compatible(left)) throw new UnitException(right.unit + " is not compatible with " + left.unit);
                float val = left.GetValue() - right.GetValue();
                return (T)left.Clone(val);
        }

        protected static T Mul<T>(T left, T right) where T : Value{
                if (!right.Compatible(left)) throw new UnitException(right.unit + " is not compatible with " + left.unit);
                float val = left.GetValue() * right.GetValue();
                return (T)left.Clone(val);
        }

        protected static T Div<T>(T left, T right) where T : Value{
                if (!right.Compatible(left)) throw new UnitException(right.unit + " is not compatible with " + left.unit);
                float val = left.GetValue() / right.GetValue();
                return (T)left.Clone(val);
        }
}
}





