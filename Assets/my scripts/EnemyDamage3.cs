using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage3 : MonoBehaviour {



    public int damageamount = 10;

    void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Player")
        if (collision.gameObject.tag == "Player")
        {
            HealthScriptForPlayer3 _health3 = collision.gameObject.GetComponent<HealthScriptForPlayer3>();

            _health3.TakeDamagee(damageamount);

            Destroy(gameObject);

        }

    }
}