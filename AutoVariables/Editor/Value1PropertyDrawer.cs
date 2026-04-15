using AutoScaleVariables;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

[CustomPropertyDrawer(typeof(Value), true)]
public class ValuePropertyDrawer : PropertyDrawer {
	
	public override VisualElement CreatePropertyGUI(SerializedProperty property) {
		VisualElement container = new();
		PropertyField nameField = new(property.FindPropertyRelative("_value"), property.displayName);
		container.Add(nameField);
		return container;
	}
}