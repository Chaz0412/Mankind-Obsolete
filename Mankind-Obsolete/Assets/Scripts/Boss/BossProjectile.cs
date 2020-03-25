using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossProjectile : MonoBehaviour
{
    public float lifespan = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject, lifespan);
    }
}
