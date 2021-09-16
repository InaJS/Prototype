using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointControl : MonoBehaviour
{
    public bool CheckPointReached;


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            CheckPointReached = true;
            
        }

    }
}
