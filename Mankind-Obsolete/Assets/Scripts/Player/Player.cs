using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;
    //public GameObject deathEffect;
    public DeathMenu deathMenu;
    public PauseMenu pauseMenu;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetHealth(currentHealth);
    }

    void Update()
    {
        healthBar.SetHealth(currentHealth);

        if(Input.GetKeyDown(KeyCode.Escape) && pauseMenu.gameObject.activeInHierarchy == false)
        {
            pauseMenu.Pause();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && pauseMenu.gameObject.activeInHierarchy == true)
        {
            pauseMenu.Resume();
        }
    }

    public void takeDamage (int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
            deathMenu.gameObject.SetActive(true);
        }
    }

    public void healthPickup()
    {
        if(currentHealth <= 80)
        {
            currentHealth += 20;
        }
        else if(currentHealth > 80)
        {
            currentHealth = maxHealth;
        }

    }

    void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        //Destroy(gameObject);
        Time.timeScale = 0f;
        gameObject.SetActive(false);

    }
}
