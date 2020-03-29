using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StunDoor : MonoBehaviour
{
    Animator animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Stun")
        {
            print("Door hit");
            animator.SetTrigger("Open");
            gameObject.SetActive(false);
        }
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Stun")
    //    {
    //        print("Door hit");
    //        animator.Play("DoorOpen");
    //        gameObject.SetActive(false);
    //    }
    //}
}
