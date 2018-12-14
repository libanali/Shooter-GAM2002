using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class DangerWarningFuel : MonoBehaviour {


    public Text DangerFUEL;

    public AudioSource FuelAlert;





	// Use this for initialization
	void Start () {


        DangerFUEL.gameObject.SetActive(false);

        FuelAlert.Stop();

		
	}
	
	// Update is called once per frame
	void LowFuel () {



        if(GetComponent<Fuel>().currentFuel <= 100)
        {

            DangerFUEL.gameObject.SetActive(true);

            FuelAlert.Play();


        }
        else
        {

            DangerFUEL.gameObject.SetActive(false);

            FuelAlert.Stop();


        }

		
	}






     void Update()
    {

        LowFuel();


    }
}
