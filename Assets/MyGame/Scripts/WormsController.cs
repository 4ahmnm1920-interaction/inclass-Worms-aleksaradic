using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormsController : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public float moveForce;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 force = new Vector3(0, jumpForce, 0);

            rb.AddForce(force);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 force = new Vector3(-moveForce, 0, 0);

            rb.AddForce(force);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 force = new Vector3(moveForce, 0, 0);

            rb.AddForce(force);
        }
    }
}
