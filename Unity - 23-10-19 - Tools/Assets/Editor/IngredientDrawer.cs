using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(Ingredient))]
public class IngredientDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        //First thing to do
        EditorGUI.BeginProperty(position, label, property);

        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

        //Saving the indentation level of text as a variable
        var indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;

        //Calculate all rect for properties to draw
        var amountRect = new Rect(position.x, position.y, 30, position.height);
        var unitRect = new Rect(position.x + 35, position.y, 50, position.height);
        var nameRect = new Rect (position.x + 90, position.y, position.width-90, position.height);

        //Draw fields
        EditorGUI.PropertyField(amountRect, property.FindPropertyRelative("amount"), GUIContent.none);
        EditorGUI.PropertyField(unitRect, property.FindPropertyRelative("unit"), GUIContent.none);
        EditorGUI.PropertyField(nameRect, property.FindPropertyRelative("name"), GUIContent.none);

        //Reset the indentation level, to ensure no other properties or fields are affected by our custom settings
        EditorGUI.indentLevel = indent;

        EditorGUI.EndProperty();
    }
}
