using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public Player player;
    public string currentScene;
    public string mainMenu;

    public void Resume()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
        player.gameObject.SetActive(true);
        AudioListener.pause = false;
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        gameObject.SetActive(true);
        player.gameObject.SetActive(false);
        AudioListener.pause = true;
    }

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
