using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Player Camera
    public Transform Player;

    void FixedUpdate ()
    {
        transform.position = new Vector3(Player.position.x, Player.position.y, transform.position.z);
    }
    
}
