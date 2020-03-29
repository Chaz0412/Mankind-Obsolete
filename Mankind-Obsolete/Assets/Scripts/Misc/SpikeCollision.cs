using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeCollision : MonoBehaviour
{
    public Player player;
    public float x;
    public float y;
    public float z;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            player.takeDamage(10);
            player.transform.position = new Vector3(x, y, z);
        }
    }
}
