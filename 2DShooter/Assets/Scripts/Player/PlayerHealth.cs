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
    public Vector3 RespawnPoint;
    public GameObject ExplosionEffect;
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

        void GiveHeal(int Heal)
    {
        
        CurrentHealth += Heal;

        HealthBar.SetHealth(CurrentHealth);

    }
        if(Collision.gameObject.tag.Equals("HealthItem"))
        {
            GiveHeal(1);
            CurrentHealth = MaxHealth;
        
        }   
    
         if(CurrentHealth <= 0)
        {
            GameObject ExpEFF = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Wait(5);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Score.ScoreValue = 0;
            
        }
        
    }

    void TakeDamage(int Damage)
    {
        
        CurrentHealth -= Damage;

        HealthBar.SetHealth(CurrentHealth);

    }
    
    //Add a delay
    IEnumerator Wait(float WaitTime)
    { //creating a function
        yield return new WaitForSeconds(WaitTime); 
        //tell unity to wait!!
    }    
}

