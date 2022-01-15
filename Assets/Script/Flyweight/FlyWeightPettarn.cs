using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyWeightPettarn : MonoBehaviour
{
    const int mapSizeX = 16;
    const int mapSizeY = 16; // 각 위치에 존재하는 지형,지물에 대해서 저장 한다고 했을 때

    FieldObject[,] fieldObjectArray = new FieldObject[mapSizeX, mapSizeY];
    // 동일한 정보는 묶어서 관리하고 다른 부분만 각자 처리하는 식의 패턴
    // 예제에서는 이동 가능 여부와 이름만 넣었다

    FieldObject fieldIsle = new FieldObject(true, "Isle");
    FieldObject fieldGuildDepot = new FieldObject(false, "GuildDepot");
    FieldObject fieldMonster = new FieldObject(true, "Monster");
    FieldObject fieldAircraftMonster = new FieldObject(true, "aircraft");

    private void Start() {
        for (int i = 0; i < mapSizeX; ++i) {
            for (int j = 0; j < mapSizeY; ++j) {
                switch (Random.Range(0, 4)) {
                    case 0:
                        fieldObjectArray[i, j] = fieldIsle;
                        break;
                    case 1:
                        fieldObjectArray[i, j] = fieldGuildDepot;
                        break;
                    case 2:
                        fieldObjectArray[i, j] = fieldMonster;
                        break;
                    case 3:
                        fieldObjectArray[i, j] = fieldAircraftMonster;
                        break;
                }
            }
        }

        for (int i = 0; i < mapSizeX; ++i) {
            for (int j = 0; j < mapSizeY; ++j) {
                // 지정된 이름의 오브젝트를 불러 오게 한다
                GameObject obj = Instantiate(Resources.Load(fieldObjectArray[i, j].objectName, typeof(GameObject))) as GameObject;
                obj.transform.localPosition = new Vector3(i, j, 0);
            }
        }
    }
}
