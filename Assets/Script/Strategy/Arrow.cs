using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour, IWeapon
{

    void Start()
    {
        
    }

    public void Shoot(GameObject obj)
    {
        Vector3 initialPosition = new Vector3(transform.position.x, transform.position.y, 0);
        //GameObject bullet = Instantiate(Resources.Load("Arrow", typeof(GameObject))) as GameObject;
        GameObject bullet = Instantiate(obj) as GameObject;
        bullet.transform.position = initialPosition;
    }

}
