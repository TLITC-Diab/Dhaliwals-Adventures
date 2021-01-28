using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    // camera / rotate
    public float MouseSpeed = 2.0f;

    public float MouseX = 0.0f;
    public float MouseY = 0.0f;
    public Rigidbody player;
    public Transform cam;

    void Start()
    {
        // Lock our cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void FixedUpdate()
    {
        // our Looking
        MouseX += MouseSpeed * Input.GetAxis("Mouse X");
        MouseY -= MouseSpeed * Input.GetAxis("Mouse Y");

        // camera rotate
        transform.eulerAngles = new Vector3(MouseY, MouseX, 0.0f);
        player.rotation = Quaternion.Euler(cam.rotation.x,0,0);
        // idfk why this ^ line doesnt work sooo.... atleast cam.rotation works slightly if not with a few small issues 
    }
}
