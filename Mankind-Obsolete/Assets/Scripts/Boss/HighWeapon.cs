using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bossBulletPrefab;
    //bool hasshot = false;

    public void HighShoot()
    {
        Instantiate(bossBulletPrefab, firePoint.position, firePoint.rotation);
    }
}