using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionSceneChange : MonoBehaviour
{

    public string LevelName = "Level_FinalBoss";

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
            SceneManager.LoadScene("Level_FinalBoss");
    }
}
