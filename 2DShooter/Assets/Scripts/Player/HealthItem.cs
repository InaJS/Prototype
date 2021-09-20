using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItem : MonoBehaviour
{
    public int CurrentHealth;
    public HealthBar HealthBar;

      //When a projectile bullet collides with the Player
    void OnCollisionEnter2D(Collision2D Collision)
    {
       if(Collision.gameObject.tag.Equals("Player"))
        {
            GiveHeal(1);
            Destroy(gameObject);
        }   
        
    }

    void GiveHeal(int Heal)
    {
        
        CurrentHealth += Heal;

        HealthBar.SetHealth(CurrentHealth);

    }
}
