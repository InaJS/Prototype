using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//The new input system refused to work.
//So the old version it is.

public class PlayerMovementOldInput : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
   

    //Camera to aim with mouse
    public Camera cam;
    Vector2 MousePos; 
    //MousePos-name for MousePosition
    void Update()
    {
        //Take Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //Look for mouse position
        MousePos = cam.ScreenToWorldPoint(Input.mousePosition);
          
    }


    void FixedUpdate()
    {
        //Move
        rb.MovePosition(rb.position + movement * MoveSpeed * Time.fixedDeltaTime);
        rb.AddForce(movement * MoveSpeed * 100 * Time.deltaTime, ForceMode2D.Force);
        

        //Aim with mouse
        Vector2 LookDir = MousePos - rb.position;
        float Angle = Mathf.Atan2(LookDir.y, LookDir.x) * Mathf.Rad2Deg -90f;
        rb.rotation = Angle;
    }

       
}

//Thanks to Brackeys.
//Elina Salmenranta