using AutoScaleVariables;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

[CustomPropertyDrawer(typeof(Value2), true)]
public class Value2PropertyDrawer : PropertyDrawer {
	
	public override VisualElement CreatePropertyGUI(SerializedProperty property) {
		VisualElement container = new();
		string help = property.type switch {
			"Value2" => "(?)",
			"Angle2" => "(degrees)",
			"Force2" => "(newtons)",
			"Length2" => "(meters)",
			"Velocity2" => "(m/s)",
			"Acceleration2" => "(m/s^2)",
			_ => ""
		};

		PropertyField nameField = new(property.FindPropertyRelative("_value"), property.displayName + " " + help);
		container.Add(nameField);
		return container;
	}
}