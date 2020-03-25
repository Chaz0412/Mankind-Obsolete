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
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
    }

    private void Update()
    {
        moveinput = Input.GetAxis("Horizontal");

        if(direction == 0)
        {
            if(Input.GetKeyDown(KeyCode.LeftShift))
            {
                animator.SetTrigger("Dash");

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
