using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnLvl2 : MonoBehaviour
{
    public GameObject Enemy;
    
    private float TimeBetweenSpawns;
    public float StartTimeBetweenSpawns;

 void Start()
    {
        TimeBetweenSpawns = StartTimeBetweenSpawns;
    } 
    
   void Update()
    {

        if(TimeBetweenSpawns <= 1)
        {
            Instantiate(Enemy, transform.position, Quaternion.identity);
            TimeBetweenSpawns = StartTimeBetweenSpawns;
        }
        else
        {
            TimeBetweenSpawns -= Time.deltaTime;
        }
    }
}