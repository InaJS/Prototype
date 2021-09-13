using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullets : MonoBehaviour
{
   //Operation Bullets
   public Transform FirePoint;
   public GameObject BulletPrefab;

   public float BulletForce = 20f;


    // Update is called once per frame
    void Update()
    {
        //Fire1 is a default keybinding in Unity. If unchanged it's at MB1.
        if(Input.GetButtonDown("Fire1"))
        { 
            Shoot();
        }
    }

    void Shoot()
    {
        //Instantiate the bullet
        GameObject Bullet = Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
        Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(FirePoint.up * BulletForce, ForceMode2D.Impulse);
    }
}
