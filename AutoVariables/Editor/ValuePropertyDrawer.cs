using AutoScaleVariables;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

[CustomPropertyDrawer(typeof(Value), true)]
public class ValuePropertyDrawer : PropertyDrawer {
	
	public override VisualElement CreatePropertyGUI(SerializedProperty property) {
		VisualElement container = new();
		string help = property.type switch {
			"Value" => "(?)",
			"Magnitude" => "(any)",
			"Time" => "(seconds)",
			"Const" => "(constant)",
			"Mass" => "(gram)",
			"Angle" => "(degrees)",
			"Force" => "(newtons)",
			"ForceAccel" => "(newtons/s)",
			"Length" => "(meters)",
			"Velocity" => "(m/s)",
			"Acceleration" => "(m/s^2)",
			_ => ""
		};

		PropertyField nameField = new(property.FindPropertyRelative("_value"), property.displayName + " " + help);
		container.Add(nameField);
		return container;
	}
}