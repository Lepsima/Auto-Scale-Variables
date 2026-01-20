using System.Collections.Generic;
using System.Linq;

public class Whatever {
	public Dictionary<string, string> unitToNames = new() {
		{ "Time", "Second" },
		{ "Mass", "Gram" },
		{ "Force", "Newton" },
		{ "Length", "Meter" },
		{ "Velocity", "MeterSecond" },
		{ "Acceleration", "MeterS2" },
	};
	
	public Dictionary<string, string> unitToNames2 = new() {
		{ "Time", "Second" },
		{ "Mass", "Gram" },
		{ "Force", "Newton" },
		{ "Length", "Meter" },
		{ "Velocity", "MeterSecond" },
		{ "Acceleration", "MeterS2" },
		{ "Angle", "AASDADASDASDDASD" }
	};

	public Dictionary<string, string> scales  = new() {
		{ "Micro", "0.000001f" },
		{ "Milli", "0.001f" },
		{ "Centi", "0.01f" },
		{ "Deci", "0.1f" },
		{ "", "1" },
		{ "Deca", "10" },
		{ "Hecto", "100" },
		{ "Kilo", "1000" },
		{ "Mega", "1000000" },
	};
	
	public Dictionary<string, string> scales2  = new() {
		{ "Micro", "1000000" },
		{ "Milli", "1000" },
		{ "Centi", "100" },
		{ "Deci", "10" },
		{ "", "1" },
		{ "Deca", "0.1f" },
		{ "Hecto", "0.01f" },
		{ "Kilo", "0.001f" },
		{ "Mega", "0.000001f" },
	};

	// public Force KiloNewton(&5 value) { return new Force(value, 1000) }
	public const string Pattern = "public static &1 &2&3(&5 value) => new(value, &4);";

	public const string Pattern2 =
		"public class &1 : &6 {\n\tpublic &1(&5 value, float scale = 1, int dimension = 1) : base(value, scale, dimension, Unit.&1) { }\n\n\tpublic static &1 operator +(&1 left, &1 right) => Add(left, right);\n\tpublic static &1 operator -(&1 left, &1 right) => Sub(left, right);\n\tpublic static &1 operator *(&1 left, &1 right) => Mul(left, right);\n\tpublic static &1 operator /(&1 left, &1 right) => Div(left, right);\n}";
	public const string Patter3 =
		"public class &6 {\n\tprivate readonly &5 value;\n\tprivate readonly float scale;\n\tprivate readonly Unit unit;\n\tprivate readonly int dimension;\n\n\tprotected &6(&5 value, float scale = 1, int dimension = 1, Unit unit = Unit.INVALID) {\n\t\tthis.value = value;\n\t\tthis.scale = scale;\n\t\tthis.dimension = dimension;\n\t\tthis.unit = unit;\n\t}\n\n\tprivate &6 Clone(&5 value) {\n\t\treturn new &6(value, scale, dimension, unit);\n\t}\n\n\tprivate &5 GetValue() {\n\t\treturn Dimension.Apply(value * scale, dimension);\n\t}\n\n\tprivate bool Compatible(&6 other) {\n\t\treturn unit == other.unit;\n\t}\n\n\tprotected static T Add<T>(T left, T right) where T : &6{\n\t\tif (!right.Compatible(left)) throw new UnitException(right.unit + \" is not compatible with \" + left.unit);\n\t\t&5 val = left.GetValue() + right.GetValue();\n\t\treturn (T)left.Clone(val);\n\t}\n\n\tprotected static T Sub<T>(T left, T right) where T : &6{\n\t\tif (!right.Compatible(left)) throw new UnitException(right.unit + \" is not compatible with \" + left.unit);\n\t\t&5 val = left.GetValue() - right.GetValue();\n\t\treturn (T)left.Clone(val);\n\t}\n\n\tprotected static T Mul<T>(T left, T right) where T : &6{\n\t\tif (!right.Compatible(left)) throw new UnitException(right.unit + \" is not compatible with \" + left.unit);\n\t\t&5 val = left.GetValue() * right.GetValue();\n\t\treturn (T)left.Clone(val);\n\t}\n\n\tprotected static T Div<T>(T left, T right) where T : &6{\n\t\tif (!right.Compatible(left)) throw new UnitException(right.unit + \" is not compatible with \" + left.unit);\n\t\t&5 val = left.GetValue() / right.GetValue();\n\t\treturn (T)left.Clone(val);\n\t}\n}";

	public const string Pattern4 = "public static &1 As&2&3(this &4 value) => value.value * &5;";
	
	private string value;
	private string value2;
	private string value3;

	public string Gen4() {
		return (from keyValuePair in unitToNames
				let unit = keyValuePair.Value
				let unitName = keyValuePair.Key
				from valuePair in scales2
				let scale = valuePair.Key
				let number = valuePair.Value
				select Pattern4.Replace("&1", value)
					.Replace("&2", scale)
					.Replace("&3", unit)
					.Replace("&4", unitName + value3)
					.Replace("&5", number)
			).Aggregate("", (current, pat) => current + (pat + "\n"));
	}
	
	public Whatever(string value, string value2, string value3) {
		this.value = value;
		this.value2 = value2;
		this.value3 = value3;
	}

	public string Master() {
		string s = "namespace VariableUnits {\n";
		s += Gen() + "\n";
		s += Gen2() + "\n";
		s += Gen3() + "\n";
		s += "}";
		return s;
	}
	
	public string Gen() {
		string v = (from keyValuePair in unitToNames
			let unit = keyValuePair.Value
			let unitName = keyValuePair.Key
			from valuePair in scales
			let scale = valuePair.Key
			let number = valuePair.Value
			select Pattern.Replace("&1", unitName + value3)
				.Replace("&2", scale)
				.Replace("&3", unit)
				.Replace("&4", number)
				.Replace("&5", value)
			).Aggregate("", (current, pat) => current + (pat + "\n"));

		return "public partial class Scales {\n" + v + "\n}";
	}

	public string Gen2() {
		return unitToNames2
			.Select(keyValuePair => keyValuePair.Key)
			.Select(val => Pattern2
				.Replace("&1", val + value3)
				.Replace("&5", value)
				.Replace("&6", value2)
			).Aggregate("", (current, res) => current + (res + "\n"));
	}
	
	public string Gen3() {
		return Patter3.Replace("&5", value).Replace("&6", value2);
	}
}