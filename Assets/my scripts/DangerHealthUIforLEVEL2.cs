using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DangerHealthUIforLEVEL2 : MonoBehaviour {


    public Text DH2;




	// Use this for initialization
	void Start () {


        DH2.gameObject.SetActive(false);

		
	}
	
	// Update is called once per frame
	void Update () {


        if (GetComponent<HealthScriptForPlayer2>().currentHealth <= 190) 
        {

            DH2.gameObject.SetActive(true);

        }

        else
        {

            DH2.gameObject.SetActive(false);

        }

		
	}
}
