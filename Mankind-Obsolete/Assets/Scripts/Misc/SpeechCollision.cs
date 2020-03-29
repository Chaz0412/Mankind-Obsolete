using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechCollision : MonoBehaviour
{
    public Player player;
    public GameObject thing;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            thing.SetActive(true);
        }
    }
}
