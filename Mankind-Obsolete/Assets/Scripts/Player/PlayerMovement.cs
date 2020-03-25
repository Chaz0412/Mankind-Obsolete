﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public Animator animator;

    public float runSpeed = 20f;

    float horizontalMove = 0f;

    bool jump = false;

    bool crouch = false;

    int canDJ = 2;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if(controller.m_Grounded)
        {
            canDJ = 2;
        }

        if(Input.GetButtonDown("Jump"))
        {
            if (canDJ > 0)
            {
                jump = true;
                animator.SetBool("IsJumping", true);
                canDJ--;
            }
            else
            {
                jump = false;
                animator.SetBool("isJumping", true);
                canDJ = 0;
            }
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if(Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
