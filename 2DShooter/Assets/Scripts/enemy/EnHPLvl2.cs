using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnHPLvl2: MonoBehaviour
{
    public int MaxHealth = 10;
    public int CurrentHealth;

    void start()
    {
        CurrentHealth = MaxHealth;
    }

    //When a bullet Collides with the enemy.
    void OnCollisionEnter2D(Collision2D Collision)
    {
       if(Collision.gameObject.tag.Equals("Bullet"))
        {
            TakeDamage(1);
        }   
    }

    void TakeDamage(int Damage)
    {
        CurrentHealth -= Damage;

         if(CurrentHealth <= 0)
        {
            Destroy(gameObject);
            Score.ScoreValue += 2;
        }
    }  
}