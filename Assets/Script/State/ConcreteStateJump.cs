using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteStateJump : State
{
    float gravity = 0.0f;
    Vector3 velocity;
    const int MAX_CHARGE = 20;

    public override void DoAction(MyState state)
    {
        Debug.Log("Jump!");
        velocity = transform.position;
        StartCoroutine(HandleJump(state));
    }

    IEnumerator HandleJump(MyState state)
    {
        gravity = 0.7f;

        while (true)
        {
            if (state == MyState.STATE_DIVING)
            {
                break;
            }

            velocity.y = velocity.y + gravity;

            transform.position = velocity;

            if (velocity.y < 1.0f)
            {
                break;
            }

            gravity = gravity - 0.1f;

            yield return new WaitForSeconds(0.05f);
        }

        gravity = 0.0f;
        velocity.y = 1.0f;
        transform.position = velocity;
        GetComponent<MyAction>().setActionType(MyState.STATE_STANDING);
        // 위코드 대신 점프 후 서있는 상태 하나를 더 만들 수도 있다.
        // state = STATE.STATE_STANDING2;

        yield return null;
    }
}
