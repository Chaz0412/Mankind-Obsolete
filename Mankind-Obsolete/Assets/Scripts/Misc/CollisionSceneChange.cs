using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionSceneChange : MonoBehaviour
{

    public string LevelName = "Level_Final";

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
            SceneManager.LoadScene(LevelName);
    }
}
