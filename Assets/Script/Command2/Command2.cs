using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 인터페이스 : Excute() 메소드만 있는 추상클래스
public abstract class CommandKey
{
    public GameObject shield;
    public GameObject cannon;
    public Transform firePos;

    public MonoBehaviour mono;

    public virtual void Excute() { }
}

// Concrete Command 객체 : 직접적으로 동작하는 객체
public class CommandAttack : CommandKey
{
    public CommandAttack(MonoBehaviour _mono, GameObject _shield, GameObject _cannon, Transform _firePos)
    {
        this.shield = _shield;
        this.cannon = _cannon;
        this.firePos = _firePos;
        this.mono = _mono;
    }

    public override void Excute()
    {
        Attack();
    }

    void Attack()
    {
        Debug.Log("Attack");
        GameObject.Instantiate(cannon, firePos.position, firePos.rotation);
    }
}

public class CommandDefense : CommandKey
{
    public CommandDefense(MonoBehaviour _mono, GameObject _shield, GameObject _cannon, Transform _firePos)
    {
        this.shield = _shield;
        this.cannon = _cannon;
        this.firePos = _firePos;
        this.mono = _mono;
    }

    public override void Excute()
    {
        Detense();
    }

    void Detense()
    {
        Debug.Log("Defense");
        shield.SetActive(true);
        mono.StartCoroutine(Desfense(0.5f));
    }

    IEnumerator Desfense(float second)
    {
        yield return new WaitForSeconds(second);
        this.shield.SetActive(false);
    }
}
