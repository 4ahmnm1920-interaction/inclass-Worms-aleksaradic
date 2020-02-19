using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public float moveForce;
    public Rigidbody projectile;
    public float Speed;
    public Transform SpawnPlayer2;

    void Start()
    {

    }

    void Update()
    {
        //jump

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 force = new Vector3(0, jumpForce, 0);

            rb.AddForce(force);
        }

        //forwards

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.drag = 1;
            transform.eulerAngles = new Vector3(0,180,0);
            if (Speed > 1) 
            {
                Speed = (Speed*(-1));
            }

            Vector3 force = new Vector3(-moveForce, 0, 0);

            rb.AddForce(force);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.drag = 20;
        }

        //backwards

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.drag = 1;
            transform.eulerAngles = new Vector3(0,0,0);
            if (Speed < 1) 
            {
                Speed = (Speed*(-1));
            }

            Vector3 force = new Vector3(moveForce, 0, 0);

            rb.AddForce(force);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.drag = 20;
        }

        //shooting

        if (Input.GetKeyDown(KeyCode.N))
        {
            Rigidbody clone;
            Vector3 pSpeed = new Vector3(Speed, 0, 0);
            clone = Instantiate(projectile, SpawnPlayer2.position, transform.rotation);
            clone.AddForce(pSpeed);

            Destroy(clone.gameObject, 2.0f);
        }
    }
}
