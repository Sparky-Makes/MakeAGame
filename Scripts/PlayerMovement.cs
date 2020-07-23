using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(new Vector3(0,0,10));
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(new Vector3(0,0,-10));
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(new Vector3(-10,0,0));
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(new Vector3(10,0,0));
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0,20,0));
        }
    }
}
