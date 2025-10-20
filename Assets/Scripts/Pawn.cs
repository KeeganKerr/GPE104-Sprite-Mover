using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;
    public float turnSpeed;
    public float turboSpeed;
    public float teleportDistance;

    [Header("Components")]
    public Health health;
    public Death death;
    public Gun gun;

   
    // Start is called before the first frame update
    void Start()
    {
       // Load the health component from this object
       health = GetComponent<Health>();
       
       // Load the Death component on start
       death = GetComponent<Death>();

       gun = GetComponent<Gun>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    public void MoveForward ( float moveSpeed)
    {
        // change my pawns position-- in the forward direction, magnitude of moveSpeed
        transform.position = transform.position + ((transform.up * moveSpeed) * Time.deltaTime);
    }

    public void MoveBackward ( float moveSpeed)
    {
        transform.position = transform.position + ((-transform.up * moveSpeed) * Time.deltaTime);
    }

    public void RotateClockwise ( float rotateValue)
    {
        transform.Rotate(0.0f, 0.0f, rotateValue * Time.deltaTime);
    }

    public void RotateCounterClockwise ( float rotateValue)
    {
        transform.Rotate(0.0f, 0.0f, -rotateValue * Time.deltaTime);
    }

    public void Teleportup(float teleportDistance)
    {
        transform.position = transform.position + (Vector3.up * teleportDistance);
    }

    public void Teleportdown( float teleportDistance)
    {
        transform.position = transform.position + (Vector3.down * teleportDistance);
    }

    public void TeleportRight( float teleportDistance)
    {
        transform.position = transform.position + (Vector3.right * teleportDistance);
    }

    public void TeleportLeft( float teleportDistance)
    {
         transform.position = transform.position + (Vector3.left * teleportDistance);
    }
}
