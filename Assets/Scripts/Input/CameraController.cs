using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float sensX;
    [SerializeField] float sensY;

    float multipiler = 0.01f;
    float xRotation;
    float yRotation;

    Camera cam;
    private void Awake()
    {
        cam = GetComponentInChildren<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void OnLook(float xLook, float yLook)
    {
        xRotation -= yLook * sensY * multipiler;
        yRotation += xLook * sensX * multipiler;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
    }
    private void Update()
    {
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        transform.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
