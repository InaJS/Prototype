using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
     public GameObject projectile;
    public Transform player;
    public Transform EnemyFirePoint;
    public GameObject ShootEffectPrefab;
    
    private float timeBetweenShots;
    public float startTimeBetweenShots;

 void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        timeBetweenShots = startTimeBetweenShots;
    } 
    
   void Update()
    {

        if(timeBetweenShots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBetweenShots = startTimeBetweenShots;

            GameObject ShootEffect = Instantiate(ShootEffectPrefab, EnemyFirePoint.position, EnemyFirePoint.rotation);
            Destroy(ShootEffect, 1f);
        }
        else
        {
            timeBetweenShots -= Time.deltaTime;
        }
    }
}
