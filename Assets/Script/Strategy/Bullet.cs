using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IWeapon
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Shoot(GameObject obj)
    {
        Vector3 initialPosition = new Vector3(transform.position.x, transform.position.y, 0);
        //GameObject bullet = Instantiate(Resources.Load("Bullet", typeof(GameObject))) as GameObject;
        GameObject bullet = Instantiate(obj) as GameObject;
        bullet.transform.position = initialPosition;
    }
}
