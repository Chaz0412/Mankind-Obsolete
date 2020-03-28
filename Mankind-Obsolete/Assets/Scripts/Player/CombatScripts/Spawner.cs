using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Animator animator;
    public GameObject projectile;

    public float projectileSpeed = 10;
    private float moveinput;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            StunBlast();
        }
    }

    void StunBlast()
    {
        animator.SetTrigger("Stun");
        moveinput = Input.GetAxis("Horizontal");
        GameObject Stunblast = Instantiate(projectile, transform.position, transform.rotation);
        Rigidbody2D rb = Stunblast.GetComponent<Rigidbody2D>();
        if (moveinput < 0)
        {
            rb.velocity = Vector2.left * projectileSpeed;
        }
        else if (moveinput > 0)
        {
            rb.velocity = Vector2.right * projectileSpeed;
        }
        else if (moveinput == 0)
        {
            rb.velocity = Vector2.right * projectileSpeed;
        }
        
    }
}
