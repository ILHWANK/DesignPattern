using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteSubject2 : MonoBehaviour
{

    public GameObject ball;
    public GameObject box1;
    public GameObject box2;
    public GameObject box3;

    //List<Observer2> observer2s = new List<Observer2>(); // 옵저버를 관리하는 List
    delegate void NotiHandler(float rot);
    NotiHandler _notiHandler;
    float time;

    void Start()
    {
        Observer2 obj1 = box1.GetComponent<ConcreteObserver2>();
        Observer2 obj2 = box2.GetComponent<ConcreteObserver2>();
        Observer2 obj3 = box3.GetComponent<ConcreteObserver2>();

        /*
        observer2s.Add(obj1);
        observer2s.Add(obj2);
        observer2s.Add(obj3);
        */

        _notiHandler += new NotiHandler(obj1.OnNotify);
        _notiHandler += new NotiHandler(obj2.OnNotify);
        _notiHandler += new NotiHandler(obj3.OnNotify);

        time = 2.0f;
    }

    public void MovePosition()
    {
        ball.transform.position = new Vector3(0, 4.5f, -3);

        /*
        foreach (Observer2 o in observer2s)
        {
            o.OnNotify(time);
        }
        */
        _notiHandler(time);

        StartCoroutine(ResetPosition(time));
    }

    IEnumerator ResetPosition(float time)
    {
        yield return new WaitForSeconds(time);
        ball.transform.position = new Vector3(0, 0.5f, -3);
    }
}
