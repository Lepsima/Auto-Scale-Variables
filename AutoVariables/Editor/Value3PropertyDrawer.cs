using AutoScaleVariables;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

[CustomPropertyDrawer(typeof(Value3<>), true)]
public class Value3PropertyDrawer : PropertyDrawer {
	
	public override VisualElement CreatePropertyGUI(SerializedProperty property) {
		VisualElement container = new();
		string help = property.type switch {
			"Value3" => "(?)",
			"Const3" => "(constant)",
			"Direction3" => "(direction)",
			"Angle3" => "(degrees)",
			"Force3" => "(newtons)",
			"Length3" => "(meters)",
			"Velocity3" => "(m/s)",
			"Acceleration3" => "(m/s^2)",
			_ => ""
		};

		PropertyField nameField = new(property.FindPropertyRelative("_value"), property.displayName + " " + help);
		container.Add(nameField);
		container.Add(nameField);
		return container;
	}
}