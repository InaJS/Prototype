using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
//Had to write that it's supposed to be using the input system.

public class PlayerMovement : MonoBehaviour
{
    //Player input with the new input system.

    [SerializeField]
    private float Speed;
    private float Horizontal;
    private float Vertical;

//An update checks every frame if the action (The key is pressed) is active.
    private void update() 
    {
        transform.localPosition += Vector3.right * Speed * Horizontal;
        transform.localPosition += Vector3.up * Speed * Vertical;
        Debug.Log("I should be moving here");
    }
    
    //Player movement
    public void Move(InputAction.CallbackContext Move)
    { 
        Horizontal = Move.ReadValue<Vector2>().x;
        Vertical = Move.ReadValue<Vector2>().y;
    }
}

//In PlayerInput in the inspector for the player. Events-Player-Move. Put this in the Move(CallbackContext)
//And the function as playerMovement-Move.
//It's not picking up on the Input from the keyboard...
//Yeah, no, this isn't working. Back to the old methods.

//Elina Salmenranta