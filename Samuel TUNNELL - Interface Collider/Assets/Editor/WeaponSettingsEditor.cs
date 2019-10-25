using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(WeaponSettings))]
public class WeaponSettingsEditor : Editor
{

    float thumbnailWidth = 88;
    float thumbnailHeight = 88;

    public override void OnInspectorGUI()
    {
        //base.DrawDefaultInspector();
        WeaponSettings weaponSettings = (WeaponSettings) target;

        GUILayout.Space(10f);

        GUILayout.BeginHorizontal();

        GUILayout.TextField("Type: " + weaponSettings.bulletType.ToString());
        GUILayout.TextField("Force: " + weaponSettings.bulletForce.ToString());
        GUILayout.TextField("RoF: " + weaponSettings.fireRate.ToString());

        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Space(140f);
        GUILayout.Label("Bullet type");
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        
        GUILayout.Space(140f);

        if (GUILayout.Button(Resources.Load<Texture2D>("Thumbnails/BigBullet"),
        GUILayout.Width(thumbnailWidth), GUILayout.Height(thumbnailHeight)))
        {
        weaponSettings.bulletType = 1;
        weaponSettings.typeUpdate();
        }

        GUILayout.Space(20f);

        /*var texture = Resources.Load<Texture>("Thumbnails/BigBullet");
        if (texture != null) {
            Debug.Log("Texture loaded");
        }
         else {
            Debug.Log("Missing image file");
        }*/

        if (GUILayout.Button(Resources.Load<Texture2D>("Thumbnails/SmallBullet"),
        GUILayout.Width(thumbnailWidth), GUILayout.Height(thumbnailHeight)))
        {
        weaponSettings.bulletType = 0;
        weaponSettings.typeUpdate();
        }

        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Space(140f);

        GUILayout.Label("7.62mm NATO.\n",
        GUILayout.Width(thumbnailWidth), GUILayout.Height(40f));

        GUILayout.Space(15f);

        GUILayout.Label("9mm standard.\n",
        GUILayout.Width(thumbnailWidth), GUILayout.Height(40f));

        GUILayout.EndHorizontal();
    }
}
