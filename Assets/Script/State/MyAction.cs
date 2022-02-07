using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MyState
{
    STATE_STANDING,
    STATE_JUMPING,
    STATE_DUCKING,
    STATE_DIVING,
    STATE_SKILL

}

public class MyAction : MonoBehaviour
{

    private MyState state;

    private State myState;

    public void setActionType(MyState state)
    {
        this.state = state;

        Component c = gameObject.GetComponent<State>() as Component;

        if (c != null)
        {
            Destroy(c);
        }

        switch (state)
        {
            case MyState.STATE_STANDING:
                myState = gameObject.AddComponent<ConcreteStateStand>();
                myState.DoAction(state);
                break;
            case MyState.STATE_JUMPING:
                myState = gameObject.AddComponent<ConcreteStateJump>();
                myState.DoAction(state);
                break;
            case MyState.STATE_DUCKING:
                myState = gameObject.AddComponent<ConcreteStateDown>();
                myState.DoAction(state);
                break;
            case MyState.STATE_DIVING:
                myState = gameObject.AddComponent<ConcreteStateAttack>();
                myState.DoAction(state);
                break;
            case MyState.STATE_SKILL:
                myState = gameObject.AddComponent<ConcreteStateSkill>();
                myState.DoAction(state);
                break;
            default:
                break;
        }
    }
    void Start()
    {
        setActionType(MyState.STATE_STANDING);
    }

    void Update()
    {
        switch (state)
        {
            case MyState.STATE_STANDING:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    setActionType(MyState.STATE_JUMPING);
                }
                else if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    setActionType(MyState.STATE_DUCKING);
                }
                break;
            case MyState.STATE_JUMPING:
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    setActionType(MyState.STATE_DIVING);
                }
                break;
            case MyState.STATE_DUCKING:
                if (Input.GetKeyUp(KeyCode.DownArrow))
                {
                    setActionType(MyState.STATE_STANDING);
                }
                break;
            default:
                break;
        }
    }
}
