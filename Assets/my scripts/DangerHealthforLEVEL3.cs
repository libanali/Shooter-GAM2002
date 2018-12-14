using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DangerHealthforLEVEL3 : MonoBehaviour {

    public Text DH3;



	// Use this for initialization
	void Start () {


        DH3.gameObject.SetActive(false);


		
	}
	
	// Update is called once per frame
	void Update () {


        if(GetComponent<HealthScriptForPlayer3>().currentHealth <= 220)
        {

            DH3.gameObject.SetActive(true);
        }

        else
        {

            DH3.gameObject.SetActive(false);
        }

		
	}
}
