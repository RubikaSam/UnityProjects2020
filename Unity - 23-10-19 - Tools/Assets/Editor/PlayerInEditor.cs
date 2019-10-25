using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PlayerEditor))]
[CanEditMultipleObjects]
public class PlayerInEditor : Editor
{
    SerializedProperty attackProperty;
    SerializedProperty defenseProperty;
    SerializedProperty weaponProperty;

    private void OnEnable() 
    {
        //Binding of properties
        attackProperty = serializedObject.FindProperty("attack");
        defenseProperty = serializedObject.FindProperty("defense"); 
        weaponProperty = serializedObject.FindProperty("weapon");     
    }

    public override void OnInspectorGUI()
    {
        //Update
        serializedObject.Update();

        //Show custom GUI controls
        EditorGUILayout.IntSlider(attackProperty, 0, 100, new GUIContent("Attack"));

        if(!attackProperty.hasMultipleDifferentValues)
        ProgressBar(attackProperty.intValue / 100f, "Attack");

        EditorGUILayout.IntSlider(defenseProperty, 0, 100, new GUIContent("Defense"));

        if(!defenseProperty.hasMultipleDifferentValues)
        ProgressBar(defenseProperty.intValue / 100f, "Defense");

        //Weapon
        EditorGUILayout.PropertyField(weaponProperty, new GUIContent("Weapon object"));

        serializedObject.ApplyModifiedProperties();
    }

    void ProgressBar(float value, string label)
    {
        Rect rect = GUILayoutUtility.GetRect(18, 18, "TextField");
        EditorGUI.ProgressBar(rect, value, label);
        EditorGUILayout.Space();
    }


}
