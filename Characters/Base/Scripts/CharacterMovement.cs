using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : BaseCharacterMovement
{
    public GroundedController groundedController;
    public override bool IsGrounded => groundedController?.IsGrounded ?? true;
    Rigidbody rb;
    Vector3 vector = new Vector3(0f, 0f, 0f);

    public override void Jamp(float force)
    {
        if (!IsGrounded) return;
        rb.AddForce(Vector3.up * force, ForceMode.Impulse);
    }

    public override void Move(Vector3 velocity)
    {
        if (IsGrounded)
        {
            vector = velocity;
            transform.Translate(velocity);
        }
        else
        {
            transform.Translate(vector);
        }
    }
    public override void Rotate(Vector3 vector)
    {
        Vector3 hor = Vector3.zero;
        hor.y = vector.x;
        transform.Rotate(hor);
    }
    // Start is called before the first frame update
    protected void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once pers frame
    protected void Update()
    {
    }
}
