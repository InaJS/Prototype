using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public float speed;
    public float stoppingDistance;
    public float retreatDistance;

    private float timeBetweenShots;
    public float startTimeBetweenShots;

    public GameObject projectile;
    public Transform player;
    public Transform FirePoint;
    public GameObject ShootEffectPrefab;

    public float BulletForce = 20f;


    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        timeBetweenShots = startTimeBetweenShots;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform != null)
        if(Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
       else if(Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        }
        else if(Vector2.Distance(transform.position, player.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }

      //  if(timeBetweenShots <= 0)
        //{
         //   Instantiate(projectile, transform.position, Quaternion.identity);
      //      timeBetweenShots = startTimeBetweenShots;
        //}
      //  else
        //{
        //    timeBetweenShots -= Time.deltaTime;
        //}

   //Ina
       // GameObject Bullet = Instantiate(projectile, FirePoint.position, FirePoint.rotation);
       // Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
     //   rb.AddForce(FirePoint.up * BulletForce, ForceMode2D.Impulse);

        //Instantiate Fire Effect
       
    //}

    //Ina has added this.
  /* void OnCollisionEnter2D (Collision2D Collision)
   {
    if(Collision.gameObject.tag.Equals("Bullet"))
    {
      Score.ScoreValue += 1;
    }
  }*/

}
}
