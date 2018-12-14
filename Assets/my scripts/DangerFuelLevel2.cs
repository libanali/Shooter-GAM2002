using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DangerFuelLevel2 : MonoBehaviour {


    public Text DF2;


	// Use this for initialization
	void Start () {



        DF2.gameObject.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {



        if(GetComponent<Fuel2>().currentFuel <= 350)

        {

            DF2.gameObject.SetActive(true);
            }

        else
        {

            DF2.gameObject.SetActive(false);
        }

        }
		
	}

