using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowWeapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bossBulletPrefab;
    bool hasshot = false;



    // Update is called once per frame
    void Update()
    {
        
        if (hasshot == false)
        {
            Shoot();
            hasshot = true;
        }
        
    }

    void Shoot()
    {
        Instantiate(bossBulletPrefab, firePoint.position, firePoint.rotation);
    }
}
