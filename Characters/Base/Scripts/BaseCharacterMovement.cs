using UnityEngine;

public abstract class BaseCharacterMovement : MonoBehaviour
{
    public abstract bool IsGrounded { get; }
    public abstract void Move(Vector3 velocity);
    public abstract void Jamp(float force);
    public abstract void Rotate(Vector3 vector);
}
