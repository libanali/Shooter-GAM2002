using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletDamage : MonoBehaviour {

    public int damageamount = 25;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           
            HealthScriptForPlayer3 _health3 = collision.gameObject.GetComponent<HealthScriptForPlayer3>();

            _health3.TakeDamagee(damageamount);


        }

    }
}