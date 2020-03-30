using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public Animator animator;
    private Rigidbody2D rb;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;
    private float moveinput;

    private Vector3 position;
    public AudioClip dashSound;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
    }

    private void Update()
    {
        moveinput = Input.GetAxis("Horizontal");

        position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);

        if (direction == 0)
        {
            if(Input.GetKeyDown(KeyCode.LeftShift))
            {
                animator.SetTrigger("Dash");
                AudioSource.PlayClipAtPoint(dashSound, position);

                if (moveinput < 0)
                {
                    direction = 1;
                }
                else if (moveinput > 0)
                {
                    direction = 2;
                }
            }
        }
        else
        {
            if(dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rb.velocity = Vector2.zero;
            }
            else
            {
                dashTime -= Time.deltaTime;

                if(direction == 1)
                {
                    rb.velocity = Vector2.left * dashSpeed;
                }
                if (direction == 2 )
                {
                    rb.velocity = Vector2.right * dashSpeed;
                }
            }
        }
    }
}
