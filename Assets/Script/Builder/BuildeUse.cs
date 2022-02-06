using UnityEngine;

public class BuildeUse : MonoBehaviour
{

    void Start()
    {
        // Instantiate the director and builders
        Engineer engineer = new Engineer();
        CarBuilder carBuilder = new CarBuilder();
        MotorCycleBuilder motorCycleBuilder = new MotorCycleBuilder();

        // 빌더를 톨해 구성해야 할 제품을 입력 받아 제품을 구성한다.
        engineer.Construct(carBuilder);
        engineer.Construct(motorCycleBuilder);

        // 최종 생산된 제품을 반환받는다.
        Vehicle car = carBuilder.getVehicle();
        Debug.Log(car.GetPartsList());

        Vehicle motorCycle = motorCycleBuilder.getVehicle();
        Debug.Log(motorCycle.GetPartsList());
    }

}
