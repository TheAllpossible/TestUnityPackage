using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : CharacterController
{
    public float rotationForce = 5;
    // Start is called before the first frame update
    protected new void Start()
    {
        base.Start();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    protected new void Update()
    {
        base.Update();
        ControlRotate();

    }
    void ControlRotate()
    {
        Vector3 rotate = Vector3.zero;
        rotate.x = Input.GetAxis("Mouse X");
        rotate.y = Input.GetAxis("Mouse Y");
        rotate *= rotationForce * Time.deltaTime * 100;

        movement.Rotate(rotate);
    }
}
