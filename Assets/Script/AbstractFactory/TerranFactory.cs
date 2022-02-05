using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// The 'ConcreteFactory1' class
/// </summary>
public class TerranFactory : RaceFactory
{

    public GameObject supply;
    public GameObject barracks;

    public override GameObject makeCapacityBuilding()
    {
        return Instantiate(supply, new Vector3(-1.0f, 1.0f, 0.0f), Quaternion.identity);
    }

    public override GameObject makeUnitbuilding()
    {
        return Instantiate(barracks, new Vector3(1.0f, 0.5f, 0.0f), Quaternion.identity);
    }
}
