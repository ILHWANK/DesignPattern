using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyweightUse : MonoBehaviour
{

    void Start()
    {
        FlyweightUnitFactory factory = GetComponent<FlyweightUnitFactory>();

        for (int i = 0; i < 10; i++)
        {
            factory.getMarine("바나나" + i);
        }

        GameObject p1 = factory.getMarine("바나나");
        GameObject p2 = factory.getMarine("사과");
        GameObject p3 = factory.getMarine("바나나");

        if (p1 == p3)
        {
            Debug.Log("name : " + p1.GetComponent<FlyweightMarine>().getName());
        }
    }
}
