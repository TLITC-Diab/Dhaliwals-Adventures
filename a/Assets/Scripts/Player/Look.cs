using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    // camera / rotate 
    public float MouseSpeed = 2.0f;

    public float MouseX = 0.0f;
    public float MouseY = 0.0f;

    void Start()
    {
        // Lock our cursor 
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // our Looking 
        MouseX += MouseSpeed * Input.GetAxis("Mouse X");
        MouseY -= MouseSpeed * Input.GetAxis("Mouse Y");

        // camera rotate 
        transform.eulerAngles = new Vector3(MouseY, MouseX, 0.0f);
    }
}