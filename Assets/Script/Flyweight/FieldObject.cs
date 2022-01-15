using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldObject
{
    public bool isAttackEnable = false;
    public string objectName = "";

    public FieldObject(bool _isAttackEnable, string _objectName) {
        isAttackEnable = _isAttackEnable;
        objectName = _objectName;
    }
}