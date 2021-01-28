using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{

    public int speed = 10;
    public int jumpForce = 1;
    public int gravity = 1;
    Rigidbody rb;

    // our rotate 
    public Vector3 Direct;

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

        // direction move 

  ///      Direct = new Vector3(x, 0.0f, z);

   ///     if (Direct != Vector3.zero)
   ///     {
  ///          transform.rotation = Quaternion.Slerp(x, 0, z);
   ///     }

  ///      rb.MovePosition(transform.position + speed * Time.deltaTime * Direct);

    }
}