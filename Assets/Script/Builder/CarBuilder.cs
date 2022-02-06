using UnityEngine;

class CarBuilder : IVehicleBuilder
{
    private Vehicle _vehicle;

    public Vehicle getVehicle()
    {
        return _vehicle;
    }

    public CarBuilder()
    {
        // 빌더가 만들어 질때 아무것도 없는 차도 하나 만든다.
        _vehicle = new Vehicle(VehicleType.Car);
    }

    public void BuildFrame()
    {
        _vehicle.AddPart("강철");
    }

    public void BuildEngine()
    {
        _vehicle.AddPart("100마력");
    }

    public void BuildWheels()
    {
        _vehicle.AddPart("왼쪽 앞 바퀴");
        _vehicle.AddPart("오른쪽 앞 바퀴");
        _vehicle.AddPart("왼쪽 뒤 바퀴");
        _vehicle.AddPart("오른쪽 두 바퀴");
    }
}
