using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScorePasteinEnemyscript : MonoBehaviour

//Paste this script into the enemy script once it's been established.
{
    void OnCollisionEnter2D (Collision2D Collision)
    {
        if(Collision.gameObject.tag.Equals("Bullet"))
        {
            Score.ScoreValue += 1;
        }
    }
}
