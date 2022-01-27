using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacePartition : MonoBehaviour
{
    public static SpaceGrid gridMap = new SpaceGrid();
    GameObject obj = null;

    private void Start()
    {
        obj = Instantiate(Resources.Load("Cube") as GameObject);
        Camera.main.gameObject.transform.parent = obj.transform;
    }

    private void Update()
    {
        // 충돌 체크
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpaceUnit unit = obj.GetComponent<SpaceUnit>();
            gridMap.HandleMelee(unit.x, unit.y);
            Debug.Log("키다운");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            gridMap.ResetColor();
            Debug.Log("키업");
        }

        // 방향키로 메인 Object 이동
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            var unit = obj.GetComponent<SpaceUnit>();
            unit.Move(-(Time.deltaTime * 10.0f), 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            var unit = obj.GetComponent<SpaceUnit>();
            unit.Move((Time.deltaTime * 10.0f), 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            var unit = obj.GetComponent<SpaceUnit>();
            unit.Move(0, -(Time.deltaTime * 10.0f));
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            var unit = obj.GetComponent<SpaceUnit>();
            unit.Move(0, (Time.deltaTime * 10.0f));
        }
    }
}
