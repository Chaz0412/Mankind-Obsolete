using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public string currentScene;
    public string mainMenu;

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(currentScene);
        gameObject.SetActive(false);
        AudioListener.pause = false;
    }

    public void QuitToMain()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        SceneManager.LoadScene(mainMenu);
    }
}
