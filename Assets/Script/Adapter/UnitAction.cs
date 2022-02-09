using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The 'Adapter' class
/// </summary>
public class UnitAction : MonoBehaviour, IUnitAction
{

    public void NormalMove(Transform tr)
    {
        tr.Translate(Vector3.forward * 1.0f);
        Debug.Log("노말 이동");
    }

    public void NormalStop(Transform tr)
    {
        Debug.Log("노말 정지");
    }
}
