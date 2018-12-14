using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateVelocity : MonoBehaviour
{



    void afterboss()


    {

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 40);


    }

}


   
