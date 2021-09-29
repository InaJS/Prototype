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
    public Animator Animator;
    private float Speed;
   
   

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
        
        //Animation
        //Animator.SetFloat("Speed", Mathf.Abs(movement)); //"Cannot convert from 'UnityEngine.Vector2 to 'float'"
        Animator.SetFloat("SpeedY", Mathf.Abs(movement.x));
        Animator.SetFloat("Speed", Mathf.Abs(movement.y));

      /*  if (Input.GetKeyDown(KeyCode.Escape))
        {
            GetComponent<Menu>().Pause();
        }*/
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