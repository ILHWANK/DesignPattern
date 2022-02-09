using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class csPlayerCommand2 : MonoBehaviour
{

    public GameObject shield;
    public GameObject cannon;
    public Transform firePos;
    bool bCmd;
    Text txt1;
    Text txt2;

    CommandKey btnZ, btnX;

    void Start()
    {
        bCmd = true;
        txt1 = GameObject.Find("Z_Key").GetComponent<Text>();
        txt2 = GameObject.Find("X_Key").GetComponent<Text>();

        SetCommand();
    }

    // SetCommand() 메소드를 통해 버튼을 누르면 어떤 동작을 수행할지를 각 버튼에 등록 한다.
    public void SetCommand()
    {
        if (bCmd == true)
        {
            btnZ = new CommandAttack(this, shield, cannon, firePos);
            btnX = new CommandDefense(this, shield, cannon, firePos);

            bCmd = false;
            txt1.text = "Z : Attack";
            txt2.text = "X : Defense";
        }
        else
        {
            btnZ = new CommandDefense(this, shield, cannon, firePos);
            btnX = new CommandAttack(this, shield, cannon, firePos);

            bCmd = true;
            txt1.text = "Z : Defense";
            txt2.text = "X : Attack";
        }
    }

    // 버튼을 누르면 단지 버튼의 Excute() 만 호출 한다.
    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            btnZ.Excute();
        }
        else if (Input.GetKeyDown("x"))
        {
            btnX.Excute();
        }
    }
}
