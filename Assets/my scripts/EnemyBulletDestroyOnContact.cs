using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletDestroyOnContact : MonoBehaviour
{




    void OnTriggerEnter2D(Collider2D collision)

    {

        if (collision.gameObject.tag == "Player")
        {

            Destroy(gameObject);

        }


        if(collision.gameObject.tag == "Bullet")
        {

            Destroy(gameObject);
        }



        if(collision.gameObject.tag == "EnemyGround")
        {

            Destroy(gameObject);
        }
    }

}
