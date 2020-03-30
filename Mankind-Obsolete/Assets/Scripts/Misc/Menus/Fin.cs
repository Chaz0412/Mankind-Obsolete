using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fin : MonoBehaviour
{
    public Boss boss;
    public int deathCount;
    public Fin fin;
    public string mainMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (boss == null && deathCount < 100)
        {
            deathCount++;
        }
        if (deathCount >= 100)
        {
            Time.timeScale = 0f;
            gameObject.SetActive(true);
            fin.gameObject.SetActive(true);
            AudioListener.pause = true;
        }
    }

    public void QuitToMain()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        SceneManager.LoadScene(mainMenu);
    }


}
