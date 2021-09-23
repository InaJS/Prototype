using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{

    public float speed;

    private Transform player;
    private Vector3 target;
    public GameObject HitEffect;
    public Rigidbody2D body;

    //testing
    //private Vector2 _movementVector = Vector2.zero;


    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector3(player.position.x, player.position.y);
        //sets the velocity of the bullet to the direction of the player, normalized to make sure it dosn't move faster than it is supposed to
        //and multiply it by speed give it the velocity of speed in the players direction
        Vector2 playersPositionRelativeToBullet = target - transform.position;
        body.velocity = playersPositionRelativeToBullet.normalized * speed;

        //_movementVector = (target.position - transform.position).normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {

        /*if (transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();

        }*/

        //transform.position += _movementVector * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //todo bullets tagged player???
        //if(other.CompareTag("Player"))
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
