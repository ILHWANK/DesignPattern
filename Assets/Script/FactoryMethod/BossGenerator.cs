using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A 'ConcreteCreator' class
/// </summary>
class BossGenerator : BossFactory
{

    public BossType type = BossType.EventBoss;
    public GameObject _normalBoss;
    public GameObject _eventBoss;

    public override void CreateBoss(Transform tran)
    {
        if (type == BossType.NormalBoss)
        {
            GameObject boss = Instantiate(_normalBoss) as GameObject;
            boss.transform.position = tran.position;
            boss.transform.localRotation = tran.localRotation;
        }
        else if (type == BossType.EventBoss)
        {
            GameObject boss = Instantiate(_eventBoss) as GameObject;
            boss.transform.position = tran.position;
            boss.transform.localRotation = tran.localRotation;
        }
    }
}
