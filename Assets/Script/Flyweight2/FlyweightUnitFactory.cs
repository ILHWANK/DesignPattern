using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyweightUnitFactory : MonoBehaviour
{
    Dictionary<string, GameObject> dic = new Dictionary<string, GameObject>();
    public GameObject marine;

    public GameObject getMarine(string name)
    {
        if (!dic.ContainsKey(name))
        {
            float x = (float)Random.Range(-10, 11);
            float z = (float)Random.Range(-10, 11);
            Vector3 pos = new Vector3(x, 1.0f, z);

            GameObject obj = Instantiate(marine, pos, Quaternion.identity);
            obj.GetComponent<FlyweightMarine>().setName(name);
            dic.Add(name, obj);

        }
        return dic[name];
    }
}
