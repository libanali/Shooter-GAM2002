using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage2 : MonoBehaviour {
 

    
    public int damageamount = 10;

     void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Player")
        if (collision.gameObject.tag == "Player")
        {
            HealthScriptForPlayer2 _health2 = collision.gameObject.GetComponent<HealthScriptForPlayer2>();

            _health2.TakeDamage(damageamount);

            Destroy(gameObject);

        }

    }
}