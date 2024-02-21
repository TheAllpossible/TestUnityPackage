using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public BaseCharacterMovement movement;
    public float speed = 2;
    public float runSpeed = 5;
    public float jumpForce = 5;

    // Start is called before the first frame update
    protected void Start()
    {
    }

    // Update is called once per frame
    protected void Update()
    {
        ControlMovement();
    }
    
    void ControlMovement()
    {
        Vector3 velocity = Vector3.zero;
        velocity.x += Input.GetAxis("Horizontal");
        velocity.z += Input.GetAxis("Vertical");
        velocity *= Time.deltaTime;
        velocity *= Input.GetKey(KeyCode.LeftShift) ? runSpeed : speed;

        movement.Move(velocity);
        if (Input.GetButtonDown("Jump")) movement.Jamp(jumpForce);
    }
}
