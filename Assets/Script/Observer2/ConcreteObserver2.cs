using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteObserver2 : Observer2
{

    float accTime = 0.0f;
    float linitTime = 0.0f;
    bool bRotate = false;

    public override void OnNotify(float time)
    {
        accTime = 0.0f;
        linitTime = time;
        bRotate = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (accTime > linitTime)
        {
            bRotate = false;
        }

        if (bRotate){
            accTime += Time.deltaTime;

            transform.Rotate(90.0f * Time.deltaTime * Vector3.up);
        }
    }
}
