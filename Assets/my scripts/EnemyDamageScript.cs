using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageScript : MonoBehaviour
{

    public int damageamount = 10;

     void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Player")
        if (collision.gameObject.tag == "Player")
        {
            HealthScriptForPlayer _health = collision.gameObject.GetComponent<HealthScriptForPlayer>();

            _health.TakeDamge(damageamount);
            

        }

    }
}