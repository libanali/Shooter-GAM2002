using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DangerFuelforLevel3 : MonoBehaviour {


    public Text DF3;



	// Use this for initialization
	void Start () {


        DF3.gameObject.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {


        if(GetComponent<Fuel3>().currentFuel <= 400)

        {

            DF3.gameObject.SetActive(true);
        }

        else
        
        {

            DF3.gameObject.SetActive(false);
        }
		
	}
}
