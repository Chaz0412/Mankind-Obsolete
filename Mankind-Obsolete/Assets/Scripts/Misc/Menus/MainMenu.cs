using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad;

    public void startGame()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
