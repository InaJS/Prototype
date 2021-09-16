using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{

    public float speed;

    private Transform player;
    private Vector2 target;
    public GameObject HitEffect;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();

        }
    }

        void OnTriggerEnter2D(Collider2D other)
        {
        
            if(other.CompareTag("Player"))
            {
            DestroyProjectile();
            }
        }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }

     
    void OnCollisionEnter2D(Collision2D Collision)
    {
        GameObject Effect = Instantiate(HitEffect, transform.position, Quaternion.identity);
        //Quaternion.Identity being the default rotation.
        Destroy(Effect, 1f);
        Destroy(gameObject);
    }
}
