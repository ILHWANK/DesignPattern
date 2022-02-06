using UnityEngine;

class MotorCycleBuilder : IVehicleBuilder
{
    private Vehicle _vehicle;

    public Vehicle getVehicle()
    {
        return _vehicle;
    }

    public MotorCycleBuilder()
    {
        // 빌더가 만들어질 때 아무것도 없는 모터사이클도 하나 만든다.
        _vehicle = new Vehicle(VehicleType.MotorCycle);
    }

    public void BuildFrame()
    {
        _vehicle.AddPart("알루미늄");
    }

    public void BuildEngine()
    {
        _vehicle.AddPart("50마력");
    }

    public void BuildWheels()
    {
        _vehicle.AddPart("앞 바퀴");
        _vehicle.AddPart("뒤 바퀴");
    }
}
