using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    int myPoint = 0;

    static PointManager _instance = null;
    public static PointManager Instance()
    {
        return _instance;
    }

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            if (this != _instance)
            {
                Destroy(this.gameObject);
            }
        }
    }

    public void AddPoint(int num)
    {
        myPoint = myPoint + num;
    }

    public int GetPoint()
    {
        return myPoint;
    }
}
