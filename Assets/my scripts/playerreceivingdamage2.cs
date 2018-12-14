using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerreceivingdamage2 : MonoBehaviour {


    
    public int damage = 10;

    void OnCollisionEnter2D(Collision2D other)

    {
        if (other.gameObject.tag == "Player")
        {

            other.gameObject.GetComponent<HealthScriptForPlayer2>
                 ().currentHealth -= damage;
        }
    }
    }

