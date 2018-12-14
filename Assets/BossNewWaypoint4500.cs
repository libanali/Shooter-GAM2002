using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossNewWaypoint4500 : MonoBehaviour
{



    public float anArbitraryDistanceNumber = 0.5f;
    public Transform[] target;

    public float speed;

    private int current;


    void Start()

    {

        GetComponent<Rigidbody2D>();

    }




    void FixedUpdate()
    {


        if (GetComponent<BossHealth>().CurrentHealth <= 4500)
        {





            //if (transform.position != target[current].position)
            if (Vector2.Distance(transform.position, target[current].position) > anArbitraryDistanceNumber)
            {

                Vector2 pos = Vector2.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
                GetComponent<Rigidbody2D>().MovePosition(pos);


            }
            else
            {

                current = (current + 1) % target.Length;
                print("Change to " + current);
            }
        }
    }
}