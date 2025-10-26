using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public float score;

    public List<DamageOnOverlap> damageZones;

    public Pawn pawn;

    [Header("Timer")]

    public float timeRemaining;

    public float maxTime;

    
    
    


    void Awake()
    {
        if(instance == null)
     {
        instance = this;
     }
     else
     {
        Destroy(gameObject);
     }

     damageZones = new List<DamageOnOverlap>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
         // Check for victory: no more damage zones
        if (damageZones.Count == 0)
        {
            Debug.Log("Victory");
        }

        // Check for failure: pawn destroyed
        if (pawn == null)
        {
            Debug.Log("Failure");
        }
    }

    public void ResetTimer()
    {
       timeRemaining = maxTime;
    }

    public void AddScore( float amount)
    {
        score += amount;
    }
}


