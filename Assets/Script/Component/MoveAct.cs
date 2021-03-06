using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum MOVE2
{
    MOVE_RIGHT,
    MOVE_LEFT
}
public class MoveAct : MonoBehaviour
{

    MOVE2 move = MOVE2.MOVE_RIGHT;

    void Start()
    {
        StartCoroutine("Move");    
    }

    IEnumerator Move()
    {
        while (true)
        {
            if (transform.position.x < -4)
            {
                move = MOVE2.MOVE_RIGHT;
            }
            else if (transform.position.x > 4)
            {
                move = MOVE2.MOVE_LEFT;
            }

            if (move == MOVE2.MOVE_RIGHT)
            {
                transform.Translate(1.0f * Vector3.right, Space.World);
            }
            else
            {
                transform.Translate(-1.0f * Vector3.right, Space.World);
            }

            yield return new WaitForSeconds(0.5f);
        }
    }

}
