using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryMethod : MonoBehaviour
{

    public Race type = Race.Terran;

    public RaceFactory getFactory()
    {
        RaceFactory factory = null;

        switch (type)
        {
            case Race.Terran:
                factory = GetComponent<TerranFactory>();
                break;

            case Race.Protoss:
                factory = GetComponent<ProtossFactory>();
                break;
        }

        return factory;
    }
}
