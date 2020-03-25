using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = -20f;
    public int damage = 40;
    public Rigidbody2D rb;
    public GameObject impactEffect;
    public float lifeSpan = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>();
        if (player != null)
        {
            player.takeDamage(damage);
        }

        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(impactEffect, lifeSpan);
    }   
}
