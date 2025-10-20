using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnOverlap : MonoBehaviour
{
    public float damageDone;
    public bool isInstaKill;
     
     //on trigger runs the proccess of the pawn taking damage or being killed via hitbox
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit! " + other.gameObject.name);

        Health otherHealth = other.gameObject.GetComponent<Health>();

        if (otherHealth != null)
        {    //Checks if the instakill is checkmarked and if not does normal damage
            if (isInstaKill)
            {
                Death death = otherHealth.GetComponent<Death>();

                if (death != null)
                {
                    death.InstaKill();
                }
                else
                {
                    
                    otherHealth.TakeDamage(otherHealth.currentHealth);
                }
            }
            else
            {
                
                otherHealth.TakeDamage(damageDone);
            }
        }
    }

    void Start()
    {
        
        
        GameManager.instance.damageZones.Add(this);
        
    }

    void Update()
    {
        
    }
    void OnDestroy()
    {
        
        
        GameManager.instance.damageZones.Remove(this);
        
        
    }
}
