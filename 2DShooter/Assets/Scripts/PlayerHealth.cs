using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //PlayerHealth to attatch with the Health bar.
    
    public int MaxHealth = 10;
    public int CurrentHealth;

    public HealthBar HealthBar;

    void start()
    {
        CurrentHealth = MaxHealth;
        HealthBar.SetMaxHealth(MaxHealth);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }
    }

    void TakeDamage(int Damage)
    {
        CurrentHealth -= Damage;

        HealthBar.SetHealth(CurrentHealth);
    }
}
