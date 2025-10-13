using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathDestroy : Death
{
   public override void IsDead()
   {
    //Destroy the game object
    Destroy(gameObject);
    

   }
}
