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

    private Vector3 position;
    public AudioClip damageSound;
    public AudioClip deathSound;
    public AudioClip healSound;



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
        position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);

    }

    public void takeDamage (int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        AudioSource.PlayClipAtPoint(damageSound, position, 50f);

        if (currentHealth <= 0)
        {
            AudioSource.PlayClipAtPoint(deathSound, position);
            Die();
            deathMenu.gameObject.SetActive(true);
        }
    }

    public void healthPickup()
    {
        AudioSource.PlayClipAtPoint(healSound, position);
        if (currentHealth <= 80)
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
