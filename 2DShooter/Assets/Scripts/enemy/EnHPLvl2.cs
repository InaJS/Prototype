using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnHPLvl2: MonoBehaviour
{
    public int MaxHealth = 10;
    public int CurrentHealth;
    public GameObject ExplosionEffect;

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
            FindObjectOfType<AudioManager>().Play("HitSound");
        }   
    }

    void TakeDamage(int Damage)
    {
        CurrentHealth -= Damage;

         if(CurrentHealth <= 0)
        {
            GameObject ExpEFF = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Score.ScoreValue += 2;
        }
    }  
}
