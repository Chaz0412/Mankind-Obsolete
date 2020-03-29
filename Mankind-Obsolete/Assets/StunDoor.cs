using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StunDoor : MonoBehaviour
{
    public Animator animator;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Stun")
        {
            animator.SetTrigger("Open");
            
        }
            
    }

    public void disableDoor()
    {
        gameObject.SetActive(false);
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
