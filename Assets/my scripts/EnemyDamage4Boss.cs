using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage4Boss : MonoBehaviour {



    public int damageamount = 10;

    void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Player")
        if (collision.gameObject.tag == "Player")
        {
            HealthScriptForPlayer4 _health4 = collision.gameObject.GetComponent<HealthScriptForPlayer4>();

            _health4.TakeDamgeee(damageamount);


        }

    }
}
