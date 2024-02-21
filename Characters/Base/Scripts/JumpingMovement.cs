using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class JumpingMovement : BaseStepperMovement
{
    [SerializeField] AnimationCurve _jampAnimation;
    public override async Task JumpAsync(EDirection to)
    {
        throw new System.NotImplementedException();
    }
    public async Task MoveAsync(EDirection to = EDirection.ToForward)
    {
        Task task = new Task(() => { });
        StartCoroutine(MoveAnimation(task));
        await task;
    }
    
    public override async Task MoveAsync(EDirection to = EDirection.ToForward, int steps = 1)
    {
        for (int i = 0; i < steps; i++)
        {
            await MoveAsync(to, i);
        }
    }

    public override async Task TurnAsync(ETurnDirection to)
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        MoveAsync(EDirection.ToForward);
        Debug.Log("finish");
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator MoveAnimation(Task task)
    {
        if (_jampAnimation.length > 0)
        {
            float max_time = _jampAnimation.keys.Last().time;
            float time = 0;
            float pos = transform.position.y;

            while (true)
            {
                yield return new WaitForFixedUpdate();
                if (time > max_time) break;

                time += Time.deltaTime;
                transform.position = new Vector3(0, pos + _jampAnimation.Evaluate(time), 0);
            }

            task.Start();
        }
    }
}
