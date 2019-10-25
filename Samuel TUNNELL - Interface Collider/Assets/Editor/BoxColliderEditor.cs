/*using UnityEngine;
using UnityEditor;

[CanEditMultipleObjects, CustomEditor(typeof(BoxCollider))]

public class BoxColliderEditor : Editor
{
    private BoxCollider _boxCollider;


    public override void OnInspectorGUI()
    {
        GUILayout.Label("OnInspectorGUI base");
        //base.OnInspectorGUI();

        _boxCollider = (BoxCollider)target;

        var initSizeX = _boxCollider.size.x;

        float sizeX;

        initSizeX = sizeX;
        float sizeY = _boxCollider.size.y;
        float sizeZ = _boxCollider.size.z;

        GUILayout.Space(20f);

        GUILayout.BeginHorizontal();
        EditorGUI.Slider(new Rect(5, 235, 150, 20), sizeX, -50, 50);
        GUILayout.EndHorizontal();

        GUILayout.Space(20f);

        GUILayout.BeginHorizontal();
        EditorGUI.Slider(new Rect(5, 255, 150, 20), sizeY, -50, 50);
        GUILayout.EndHorizontal();

        GUILayout.Space(20f);

        GUILayout.BeginHorizontal();
        EditorGUI.Slider(new Rect(5, 285, 150, 20), sizeZ, -50, 50);
        GUILayout.EndHorizontal();

        GUILayout.Space(20f);

        EditorGUILayout.FloatField("X", _boxCollier.size.x);
    }

    
}*/
