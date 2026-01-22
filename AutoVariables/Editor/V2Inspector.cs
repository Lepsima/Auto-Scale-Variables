using AutoScaleVariables;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(Value2UI), true)]
public class V2Inspector : PropertyDrawer {
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
		EditorGUI.BeginProperty(position, label, property);
		position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

		int indent = EditorGUI.indentLevel;
		EditorGUI.indentLevel = 0;
		
		(Rect left, Rect right) = SplitRect(position, 0.25f);
		Vector2Property(left, property);
		EnumProperty(right, property);

		EditorGUI.indentLevel = indent;
		EditorGUI.EndProperty();
	}

	private static (Rect, Rect) SplitRect(Rect position, float ratio) {
		float leftWidth = position.width * (1f - ratio);
		float rightWidth = position.width * ratio;

		Rect left  = new(position.x, position.y, leftWidth - 2, position.height);
		Rect right = new(position.x + leftWidth + 2, position.y, rightWidth - 2, position.height);

		return (left, right);
	}

	private static void EnumProperty(Rect rect, SerializedProperty property) {
		SerializedProperty prop = property.FindPropertyRelative("type");
		EditorGUI.PropertyField(rect, prop, GUIContent.none);
	}
	
	private static void Vector2Property(Rect rect, SerializedProperty property) {
		SerializedProperty valueProp = property.FindPropertyRelative("_value");
		Vector2 v = valueProp.vector2Value;
		float[] values = { v.x, v.y };
		
		GUIContent[] labels = { GUIContent.none, GUIContent.none, GUIContent.none };
		EditorGUI.MultiFloatField(rect, GUIContent.none, labels, values);
		valueProp.vector2Value = new Vector2(values[0], values[1]);
	}

	public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
		return EditorGUIUtility.singleLineHeight;
	}
}