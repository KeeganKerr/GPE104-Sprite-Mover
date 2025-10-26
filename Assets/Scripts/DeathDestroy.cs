using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathDestroy : Death
{
   public float scoreValue;

   public override void IsDead()
   {
      if (GameManager.instance != null)
      {
         GameManager.instance.AddScore(scoreValue);
      }


    //Destroy the game object
    Destroy(gameObject);
    

   }
}
