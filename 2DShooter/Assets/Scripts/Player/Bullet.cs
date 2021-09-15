using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //Triggers when collides with something

    //Instantiate the Hit Effect
    public GameObject HitEffect;
    void OnCollisionEnter2D(Collision2D Collision)
    {
        GameObject Effect = Instantiate(HitEffect, transform.position, Quaternion.identity);
        //Quaternion.Identity being the default rotation.
        Destroy(Effect, 1f);
        Destroy(gameObject);
    }
}
