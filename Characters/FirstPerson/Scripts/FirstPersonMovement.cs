using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class FirstPersonMovement : CharacterMovement
{
    public Camera camera;

    public override void Rotate(Vector3 vector)
    {
        base.Rotate(vector);

        Vector3 ver = Vector3.zero;
        ver.x = vector.y * -1;

        float angle = camera.transform.rotation.eulerAngles.x;
        if (angle > 60 && angle < 90 && ver.x > 0
            || angle > 270 && angle < 300 && ver.x < 0)
            ver.x = 0;

        camera?.transform?.Rotate(ver);
    }
}
