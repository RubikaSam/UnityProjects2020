using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(FpsControllerLPFP))]
public class FPSControllerEditor : Editor
{
    float labelWidth = 150f;

    string presetName = "Preset 1";

    public override void OnInspectorGUI()
    {
    base.DrawDefaultInspector();

    FpsControllerLPFP fpsController = (FpsControllerLPFP) target;
    float _wSpeed = fpsController.walkingSpeed;
    float _rSpeed = fpsController.runningSpeed;
    float _mSmootheness = fpsController.movementSmoothness;
    float _jumpForce = fpsController.jumpForce;
    float _mouseSensitivity = fpsController.mouseSensitivity;
    float _rotationSmootheness = fpsController.rotationSmoothness;
    float _minAngle = fpsController.minVerticalAngle;
    float _maxAngle = fpsController.maxVerticalAngle;



    GUILayout.Space(20f);
    GUILayout.Label("Custom Editor Elements", EditorStyles.boldLabel);

    GUILayout.Space(10f);

    GUILayout.BeginHorizontal();
    GUILayout.Label("Preset Name", GUILayout.Width(labelWidth));
    presetName = GUILayout.TextField(presetName);
    GUILayout.EndHorizontal();

    GUILayout.BeginHorizontal();
if (GUILayout.Button("Save"))
{
    EditorPrefs.SetString("Preset Name", presetName);

    EditorPrefs.SetFloat("Walking Speed", _wSpeed);
    EditorPrefs.SetFloat("Running Speed", _rSpeed);
    EditorPrefs.SetFloat("Movement Smootheness", _mSmootheness);
    EditorPrefs.SetFloat("Jump Force", _jumpForce);
    EditorPrefs.SetFloat("Mouse Sensitivity", _mouseSensitivity);
    EditorPrefs.SetFloat("Rotation Smootheness", _rotationSmootheness);
    EditorPrefs.SetFloat("Min. Vertical Angle", _minAngle);
    EditorPrefs.SetFloat("Max. Vertical Angle", _maxAngle);

    Debug.Log("Preset Saved");
}

if (GUILayout.Button("Load"))
{
    EditorPrefs.GetString("Preset Name", presetName);

    fpsController.walkingSpeed = EditorPrefs.GetFloat("Walking Speed", 5f);
    fpsController.runningSpeed = EditorPrefs.GetFloat("Running Speed", 9f);
    fpsController.movementSmoothness = EditorPrefs.GetFloat("Movement Smootheness", 0.1f);
    fpsController.jumpForce = EditorPrefs.GetFloat("Jump Force", 30f);
    fpsController.mouseSensitivity = EditorPrefs.GetFloat("Mouse Sensitivity", 5);
    fpsController.rotationSmoothness = EditorPrefs.GetFloat("Rotation Smootheness", 0.05f);
    fpsController.minVerticalAngle = EditorPrefs.GetFloat("Min. Vertical Angle", -90);
    fpsController.maxVerticalAngle = EditorPrefs.GetFloat("Max. Vertical Angle", 90);
    Debug.Log("Preset Loaded");
}

    if (GUILayout.Button("Reset"))
{
    EditorPrefs.DeleteAll();
    fpsController.walkingSpeed = EditorPrefs.GetFloat("Walking Speed", 5f);
    fpsController.runningSpeed = EditorPrefs.GetFloat("Running Speed", 9f);
    fpsController.movementSmoothness = EditorPrefs.GetFloat("Movement Smootheness", 0.1f);
    fpsController.jumpForce = EditorPrefs.GetFloat("Jump Force", 30f);
    fpsController.mouseSensitivity = EditorPrefs.GetFloat("Mouse Sensitivity", 5);
    fpsController.rotationSmoothness = EditorPrefs.GetFloat("Rotation Smootheness", 0.05f);
    fpsController.minVerticalAngle = EditorPrefs.GetFloat("Min. Vertical Angle", -90);
    fpsController.maxVerticalAngle = EditorPrefs.GetFloat("Max. Vertical Angle", 90);
    Debug.Log("Preset Reset");
}

GUILayout.EndHorizontal();
    }
}
