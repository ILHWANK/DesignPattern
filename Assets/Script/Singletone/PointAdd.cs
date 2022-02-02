using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAdd : MonoBehaviour
{

    public int myNum = 0;

    void Start()
    {
        MyFunc();    
    }

    void MyFunc()
    {
        PointManager.Instance().AddPoint(myNum);
        int myResult = PointManager.Instance().GetPoint();
        Debug.Log("Point : " + myResult);
    }
}
