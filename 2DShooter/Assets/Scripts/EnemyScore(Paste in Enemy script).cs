using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScorePasteinEnemyscript : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D Collision)
    {
        if(Collision.gameObject.tag.Equals("Bullet"))
        {
            Score.ScoreValue += 1;
        }
    }
}
