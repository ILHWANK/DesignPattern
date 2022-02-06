using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IVehicleBuilder
{
    Vehicle getVehicle();

    void BuildFrame();
    void BuildEngine();
    void BuildWheels();
}

public enum VehicleType
{
    Car,
    MotorCycle
}