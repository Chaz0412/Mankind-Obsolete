﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage = 10;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        Boss boss = hitInfo.GetComponent<Boss>();
        if (enemy != null)
        {
            enemy.takeDamage(damage);
        }
        if (boss != null)
        {
            boss.takeDamage(damage);
        }
        Destroy(gameObject);
    }
}
