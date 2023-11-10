using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float force = 5.0f;
    public float jumpSpeed = 15f;
    private float hInput;
    private float vInput;
    private Vector3 moveDirection;
    private Rigidbody rb;
    private bool isGrounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
        moveDirection = new Vector3(hInput, 0, vInput);

        
        
        if (GetComponent<Rigidbody>().velocity.y == 0)
        {
            isGrounded = true;
        } else
        {
            isGrounded = false;
        }
        
    }

    private void FixedUpdate()
    {
        rb.AddForce(moveDirection * force);

        if (Input.GetKey(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(Vector3.up * jumpSpeed);
        }
    }

}
