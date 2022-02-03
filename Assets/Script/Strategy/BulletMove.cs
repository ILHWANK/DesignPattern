using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    float Speed = 10.0f;


    void Update()
    {
        this.transform.Translate(Vector3.up * Speed * Time.deltaTime);

        if (this.transform.position.y > 10.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
