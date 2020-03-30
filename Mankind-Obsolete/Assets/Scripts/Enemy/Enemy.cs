using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public GameObject deathEffect;

    private Vector3 position;
    public AudioClip deathSound;

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {

        position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    public void takeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        AudioSource.PlayClipAtPoint(deathSound, position);
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        gameObject.SetActive(false);
    }
}
