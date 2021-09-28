using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//To load a new scene, UnityEngine.SceneManagement needs to be in use.
public class Menu : MonoBehaviour
{
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
}
