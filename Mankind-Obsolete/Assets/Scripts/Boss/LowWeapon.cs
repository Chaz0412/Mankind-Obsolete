using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowWeapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bossBulletPrefab;



    // Update is called once per frame
    //void Update()
    //{
    //    Shoot();
    //}

    void Shoot()
    {
        Instantiate(bossBulletPrefab, firePoint.position, firePoint.rotation);
    }
}
