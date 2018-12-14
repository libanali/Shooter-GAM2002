using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContactWithEnemyGround : MonoBehaviour
{



    void OnTriggerEnter2D(Collider2D collision)

    {

        if (collision.gameObject.tag == "EnemyGround")

        {

            Destroy(gameObject);
        }
    }
}