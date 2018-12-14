using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour {



    public int damageamount = 25;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Enemy")
        {
            print("I'm hit");
            Target _health = collision.gameObject.GetComponent<Target>();

            _health.TakeDamage(damageamount);


        }

    }
}