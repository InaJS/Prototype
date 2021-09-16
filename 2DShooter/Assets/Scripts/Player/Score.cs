using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int ScoreValue = 0;
    Text Points;

    // Start is called before the first frame update
    void Start()
    {
        //Display and change score
        Points = GetComponent<Text> ();

        
    }

    // Update is called once per frame
    void Update()
    {
        Points.text = "Score: " + ScoreValue;

        if(ScoreValue >= 25)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
