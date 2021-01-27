using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{

    public int speed = 10;
    public int jumpForce = 1;
    public int gravity = 1;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 moveBy = (transform.right * x + transform.forward * z);

        if (Input.GetAxis("Fire3") < 1)
        {
            speed = 10;
        }
        else
        {
            speed = 17;
        }
        Debug.Log(speed);
        rb.MovePosition(transform.position + moveBy.normalized * speed * Time.deltaTime);

    }
}
