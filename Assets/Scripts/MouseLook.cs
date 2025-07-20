using System;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public enum RotationAxis
    {
        MouseXandY,
        MouseX,
        MouseY
    }

    public RotationAxis Axes = RotationAxis.MouseXandY;

    public float HorizontalSensivity;
    public float VerticalSensevity;

    private float minimumVert = -45f;
    private float maximumVert = 45f;

    private float rotationX;

    void Start()
    {

        Rigidbody body = GetComponent<Rigidbody>();
        if (body != null)
            body.freezeRotation = true;


    }


    void Update()
    {
        if (Axes == RotationAxis.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * HorizontalSensivity, 0);

        }
        else if (Axes == RotationAxis.MouseY)
        {
            rotationX -= Input.GetAxis("Mouse Y") * VerticalSensevity;
            rotationX = Mathf.Clamp(rotationX, minimumVert, maximumVert);

            float rotationY = transform.localEulerAngles.y;

            transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
        }
        else
        {
            rotationX -= Input.GetAxis("Mouse Y") * VerticalSensevity;
            rotationX = Mathf.Clamp(rotationX, minimumVert, maximumVert);

            float deltaY = Input.GetAxis("Mouse X") * HorizontalSensivity;
            float rotationY = transform.localEulerAngles.y + deltaY;

            transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);


        }
    }
}
