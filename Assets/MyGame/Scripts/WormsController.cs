using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormsController : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public float moveForce;
    public Rigidbody projectile;
    public float Speed;
    public Transform Spawn;


    void Start()
    {

    }
    
    void Update()
    {
        //jump

        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 force = new Vector3(0, jumpForce, 0);

            rb.AddForce(force);
        }

        //forwards

        if (Input.GetKey(KeyCode.D))
        {
            rb.drag = 1;

            Vector3 force = new Vector3(-moveForce, 0, 0);

            rb.AddForce(force);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.drag = 20;
        }

        //backwards

        if (Input.GetKey(KeyCode.A))
        {
            rb.drag = 1;

            Vector3 force = new Vector3(moveForce, 0, 0);

            rb.AddForce(force);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.drag = 20;
        }

        //shooting right

        if (Input.GetKeyDown(KeyCode.V))
        {

            Rigidbody clone;
            Vector3 pSpeed = new Vector3(Speed, 0, 0);
            clone = Instantiate(projectile, Spawn.position, transform.rotation);
            clone.AddForce(pSpeed);

            Destroy(clone.gameObject, 2.0f);
        }

    }
}
