using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript : MonoBehaviour
{


    public GameObject leftB, rightB;

    private Vector2 dist;






    void Update()
    {

        if (this.gameObject.transform.position.x > leftB.transform.position.x && this.gameObject.transform.position.x < rightB.transform.position.x)
        {

            GetComponent<newplayermovement>();

        }
        else
        {

            dist = Vector2.zero;
            transform.position = Vector2.MoveTowards(transform.position, dist, 2.0f);
        }
    }
}



