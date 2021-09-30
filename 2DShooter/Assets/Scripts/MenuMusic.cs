
using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    void Start()
    {
        if (Application.loadedLevelName == "MainMenu")
        {
            FindObjectOfType<AudioManager>().StopPlaying("LevelMusic");
            FindObjectOfType<AudioManager>().Play("MenuMusic");
        }

        else if (Application.loadedLevelName == "Level1")
        {
            FindObjectOfType<AudioManager>().StopPlaying("MenuMusic");
            FindObjectOfType<AudioManager>().Play("LevelMusic");

        }

        else if (Application.loadedLevelName == "End")
        {
            FindObjectOfType<AudioManager>().StopPlaying("LevelMusic");
            FindObjectOfType<AudioManager>().Play("MenuMusic");
        }
    }
}
