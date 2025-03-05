using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;  // Movement speed
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();  // Get Rigidbody component
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // Get A/D or Left/Right input
        float moveVertical = Input.GetAxis("Vertical"); // Get W/S or Up/Down input

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed); // Apply force to move the sphere
    }
}
