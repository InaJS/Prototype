using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    //PlayerHealth to attatch with the Health bar.
    
    public int MaxHealth = 10;
    public int CurrentHealth;
    public Transform CheckPnt;
    GameObject Player;

    public HealthBar HealthBar;

    void start()
    {
        CurrentHealth = MaxHealth;
        HealthBar.SetMaxHealth(MaxHealth);
    }

    //When a projectile bullet collides with the Player
    void OnCollisionEnter2D(Collision2D Collision)
    {
       if(Collision.gameObject.tag.Equals("EnemyBullet"))
        {
            TakeDamage(1);
        }   

    
         if(CurrentHealth <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Player.transform.position = CheckPnt.position;
        }
    }

    void TakeDamage(int Damage)
    {
        
        CurrentHealth -= Damage;

        HealthBar.SetHealth(CurrentHealth);

    } 
}
