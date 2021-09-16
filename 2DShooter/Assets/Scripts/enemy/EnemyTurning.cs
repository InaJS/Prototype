using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurning : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 PlayerPos; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     //Aim with mouse
        Vector2 LookDir = PlayerPos - rb.position;
        float Angle = Mathf.Atan2(LookDir.y, LookDir.x) * Mathf.Rad2Deg -90f;
        rb.rotation = Angle;
    }
}
