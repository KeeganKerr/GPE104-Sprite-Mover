using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    // sets the min and max distance the sprite can teleport
    public float xRange = 5f;
    public float yRange = 5f;

    void Update()
    {
        // Teleports when key is pressed "space"
        if (Input.GetKeyDown(KeyCode.T))
        {
            SetNewPosition();
        }
    }

    void SetNewPosition()
    {
       
          // Determines the area the sprite can teleport to
        float randomX = Random.Range(-xRange, xRange);
        float randomY = Random.Range(-yRange, yRange);
        Vector2 newPosition = new Vector2(randomX, randomY);
        


        //Updates position of the sprite
        transform.position = newPosition;
    }
}
