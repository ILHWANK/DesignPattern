using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 엎드리기 클래스
public class ConcreteStateDown : State
{

    int chargeTime = 0;
    const int MAX_CHARGE = 10;

    public override void DoAction(MyState state)
    {
        Debug.Log("Down !");
        // 엎드리기
        StartCoroutine(HandleDown(state));
        // 기모으/
        StartCoroutine(HandleSkill());
    }

    IEnumerator HandleDown(MyState state)
    {
        //transform.Rotate(Vector3.right * 90.0f);
        transform.Rotate(Vector3.right * 90.0f);
        transform.position = new Vector3(0, 0.5f, 0);
        yield return null;
    }

    IEnumerator HandleSkill()
    {
        chargeTime = 0;
        while (true)
        {
            chargeTime++;
            if (chargeTime > MAX_CHARGE)
            {
                chargeTime = 0;
                // 스킬 발동;
                GetComponent<MyAction>().setActionType(MyState.STATE_SKILL);
                yield return null;
            }

            yield return new WaitForSeconds(0.1f);
        }
    }
}
