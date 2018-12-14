using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletDamage4Boss : MonoBehaviour
{



    public int damageamount = 15;


    void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Player")
        {

            HealthScriptForPlayer4 _health7 = collision.gameObject.GetComponent<HealthScriptForPlayer4>();

            _health7.TakeDamgeee(damageamount);

        }
    }
}



