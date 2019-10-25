using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float horizontalSpeed = 2f;
    public float verticalSpeed = 2f;

    private float yaw = 0f;
    private float pitch = 0f;


    void Update()
    {
        yaw += horizontalSpeed * Input.GetAxis("Mouse X");
        pitch += verticalSpeed * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0f);
    }
}
