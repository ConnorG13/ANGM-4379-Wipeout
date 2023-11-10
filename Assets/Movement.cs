using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float force = 5.0f;
    private float hInput;
    private float vInput;
    private Vector3 moveDirection;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
        moveDirection = new Vector3(hInput, 0, vInput);
    }

    private void FixedUpdate()
    {
        rb.AddForce(moveDirection * force);
    }

}
