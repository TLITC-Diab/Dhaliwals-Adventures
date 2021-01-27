using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{

    public int speed;
    public int jumpForce;
    public int gravity;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Debug.Log(x);
        Debug.Log(z);
        Vector3 moveBy = (transform.right * x + transform.forward * z);

        rb.MovePosition(transform.position + moveBy.normalized * speed * Time.deltaTime);

    }
}
