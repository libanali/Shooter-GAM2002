using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeFuel : MonoBehaviour
{



    public int SubtractFuel = 20;






    private void FixedUpdate()
    {

        if(gameObject.tag == "Player") {


            GetComponent<Fuel>().currentFuel -= SubtractFuel; 
        }


        }


    }












