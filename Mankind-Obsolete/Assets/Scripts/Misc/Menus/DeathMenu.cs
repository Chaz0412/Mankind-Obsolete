using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenu : MonoBehaviour
{
    
    public void RestartGame()
    {
        Time.timeScale = 1f;
        //insert code to reset level
        gameObject.SetActive(false);
        AudioListener.pause = false;
    }

    public void QuitToMain()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        //insert code to quit to main
    }
}
