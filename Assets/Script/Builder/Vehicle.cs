using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Vehicle
{

    public VehicleType vehicleType;
    private List<string> _parts = new List<string>();

    public Vehicle(VehicleType vehicleType)
    {
        this.vehicleType = vehicleType;
    }

    public void AddPart(string desc)
    {
        _parts.Add(desc);
    }

    public string GetPartsList()
    {
        string partList = vehicleType.ToString() + "parts:\n\t";
        foreach (string part in _parts)
        {
            partList += part + " ";
        }

        return partList;
    }
}
