using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//To load a new scene, UnityEngine.SceneManagement needs to be in use.
public class Menu : MonoBehaviour
{

    [SerializeField] GameObject pauseMenu;

    public static bool GameIsPaused = false;

    public void Play()
    {
        SceneManager.LoadScene("Level1");

    }

    public void Continue()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    //Quit the Application.
    public void Quit()
    {
        //Won't happen in the Editor. So to make sure it's working.
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Rules ()
    {
        SceneManager.LoadScene("Rules");
    }

    public void RespawnLvl1()
    {
        SceneManager.LoadScene("Level1");

    }

    public void RespawnLvl2()
    {
        SceneManager.LoadScene("Level2");
     }

     public void RespawnLvl3()
    {
        SceneManager.LoadScene("Level3");

    }

     public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");

    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
}
