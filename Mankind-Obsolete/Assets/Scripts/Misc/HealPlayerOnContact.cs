using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPlayerOnContact : MonoBehaviour
{
    public Player player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            player.healthPickup();
            Destroy(gameObject);
        }
    }
}
