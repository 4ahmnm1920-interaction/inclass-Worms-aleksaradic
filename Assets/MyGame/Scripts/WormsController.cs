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

    //keys
    public KeyCode JumpKey;
    public KeyCode LeftKey;
    public KeyCode RightKey;
    public KeyCode ShootKey;


    void Start()
    {

    }
    
    void Update()
    {
        //jump

        if (Input.GetKeyDown(JumpKey))
        {
            Vector3 force = new Vector3(0, jumpForce, 0);

            rb.AddForce(force);
        }

        //move right

        if (Input.GetKey(RightKey))
        {
            rb.drag = 1;
            transform.eulerAngles = new Vector3(0,0,0);
            if (Speed > 1) 
            {
                Speed = (Speed*(-1));
            }
            Vector3 force = new Vector3(-moveForce, 0, 0);

            rb.AddForce(force);
        }

        if (Input.GetKeyDown(RightKey))
        {
            rb.drag = 20;
        }

        //move left

        if (Input.GetKey(LeftKey))
        {
            rb.drag = 1;
            transform.eulerAngles = new Vector3(0,180,0);
            if (Speed < 1) 
            {
                Speed = (Speed*(-1));
            }

            Vector3 force = new Vector3(moveForce, 0, 0);

            rb.AddForce(force);
        }

        if (Input.GetKeyDown(LeftKey))
        {
            rb.drag = 20;
        }

        //shooting

        if (Input.GetKeyDown(ShootKey))
        {

            Rigidbody clone;
            Vector3 pSpeed = new Vector3(Speed, 0, 0);
            clone = Instantiate(projectile, Spawn.position, transform.rotation);
            clone.AddForce(pSpeed);

            Destroy(clone.gameObject, 2.0f);
        }

    }
}
