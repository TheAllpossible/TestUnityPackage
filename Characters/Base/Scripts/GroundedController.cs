using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedController : MonoBehaviour
{
    int _connected = 0;
    public bool IsGrounded => _connected > 0;

    void OnTriggerEnter(Collider other)
    {
        _connected++;
    }
    void OnTriggerExit(Collider other)
    {
        _connected--;
    }
}
