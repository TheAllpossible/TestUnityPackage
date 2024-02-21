using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public abstract class BaseStepperMovement : MonoBehaviour
{
    public abstract Task MoveAsync(EDirection to = EDirection.ToForward, int steps = 1);
    public abstract Task TurnAsync(ETurnDirection to);
    public abstract Task JumpAsync(EDirection to);

    public enum ETurnDirection
    {
        ToRight,
        ToLeft,
    }
    public enum EDirection
    {
        ToRight,
        ToLeft,
        ToForward,
        ToBack,
    }
}
