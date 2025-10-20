using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Pawn pawn;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Based on inputs, send commands to Pawn
        MoveIt();
    }

    private void MoveIt( )
    {
        if( Input.GetKey(KeyCode.W))
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            pawn.MoveForward(pawn.turboSpeed);
        }
        else
        {
            // Tell Pawn to move Forward
            pawn.MoveForward( pawn.moveSpeed);
        }
    }
        if( Input.GetKey(KeyCode.S))
        {
            // Tell Pawn to move Backward
            pawn.MoveBackward(pawn.moveSpeed);
        }
        if( Input.GetKey(KeyCode.D))
        {
            // Tell Pawn to turn clockwise
            pawn.RotateCounterClockwise( pawn.turnSpeed);
        }
         if( Input.GetKey(KeyCode.A))
        {
            // Tell Pawn to turn counterclockwise
            pawn.RotateClockwise( pawn.turnSpeed);
        }
        if( Input.GetKeyDown(KeyCode.UpArrow))
        {
            pawn.Teleportup(pawn.teleportDistance);
        }
         if( Input.GetKeyDown(KeyCode.DownArrow))
        {
            pawn.Teleportdown(pawn.teleportDistance);
        }
         if( Input.GetKeyDown(KeyCode.RightArrow))
        {
            pawn.TeleportRight(pawn.teleportDistance);
        }
         if( Input.GetKeyDown(KeyCode.LeftArrow))
        {
            pawn.TeleportLeft(pawn.teleportDistance);
        }
        if( Input.GetKeyDown(KeyCode.Space))
        {
            pawn.gun.Shoot();
        }
        





    }
}
