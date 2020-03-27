using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowWeapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bossBulletPrefab;
    bool hasshot = false;

    public void LowShoot()
    {
        Instantiate(bossBulletPrefab, firePoint.position, firePoint.rotation);
    }
}