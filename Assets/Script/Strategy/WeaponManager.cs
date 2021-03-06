using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType
{
    Bullet,
    Missile,
    Arrow
}

public class WeaponManager : MonoBehaviour
{

    public GameObject _arrow;
    public GameObject _bullet;
    public GameObject _missile;
    private GameObject myWeapon;

    private IWeapon weapon;

    private void setWeaponType (WeaponType weaponType)
    {

        Component c = gameObject.GetComponent<IWeapon>() as Component;

        if (c != null){
            Destroy(c);
        }

        switch (weaponType)
        {
            case WeaponType.Bullet :
                weapon = gameObject.AddComponent<Bullet>();
                myWeapon = _bullet;
                break;

            case WeaponType.Arrow :
                weapon = gameObject.AddComponent<Arrow>();
                myWeapon = _arrow;
                break;
            
            case WeaponType.Missile :
                weapon = gameObject.AddComponent<Missile>();
                myWeapon = _missile;
                break;
            
            default:
                weapon = gameObject.AddComponent<Bullet>();
                myWeapon = _bullet;
                break;
        }
    }

    void Start()
    {
        setWeaponType(WeaponType.Bullet);
    }

    public void ChangeBullet()
    {
        setWeaponType(WeaponType.Bullet);
    }

    public void ChangeMissile()
    {
        setWeaponType(WeaponType.Missile);
    }

    public void ChangeArrow()
    {
        setWeaponType(WeaponType.Arrow);
    }

    public void Fire()
    {
        weapon.Shoot(myWeapon);
    }
}
