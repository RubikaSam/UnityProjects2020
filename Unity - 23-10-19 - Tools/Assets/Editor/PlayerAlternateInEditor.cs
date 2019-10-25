using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PlayerAlternate))]
[CanEditMultipleObjects]
public class PlayerAlternateInEditor : Editor
{
    public override void OnInspectorGUI()
    {
        PlayerAlternate playerAlternate = (PlayerAlternate)target;

        playerAlternate.attack = EditorGUILayout.IntSlider("Attack", playerAlternate.attack, 0, 100);
        ProgressBar(playerAlternate.attack/100f, "Attack");

        playerAlternate.defense = EditorGUILayout.IntSlider("Defense", playerAlternate.defense, 0, 100);
        ProgressBar(playerAlternate.defense/100f, "Defense");

        bool allowSceneObjects = !EditorUtility.IsPersistent(target);
        playerAlternate.weapon = (GameObject)EditorGUILayout.ObjectField("Weapon Object",
                                                                        playerAlternate.weapon,
                                                                        typeof(GameObject),
                                                                        allowSceneObjects);
    }

    void ProgressBar(float value, string label)
    {
        Rect rect = GUILayoutUtility.GetRect(18, 18, "TextField");
        EditorGUI.ProgressBar(rect, value, label);
        EditorGUILayout.Space();
    }

}
