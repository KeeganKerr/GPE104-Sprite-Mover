using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTests : MonoBehaviour
{
    public Pawn pawnToTest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            pawnToTest.death.IsDead();
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            pawnToTest.health.TakeDamage(1);
        }
         if (Input.GetKeyDown(KeyCode.O))
        {
            pawnToTest.health.Heal(1);
        }
    }
}
