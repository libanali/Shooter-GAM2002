using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DangerWarningHealthUIforboss : MonoBehaviour {



    public Text DangerHealth4boss;



	// Use this for initialization
	void Start () {


        DangerHealth4boss.gameObject.SetActive(false);

		
	}
	
	// Update is called once per frame
	void Update () {
		

        if(GetComponent<HealthScriptForPlayer4>().currentHealth <= 270)
        {

            DangerHealth4boss.gameObject.SetActive(true);
        }

        else
        {
            DangerHealth4boss.gameObject.SetActive(false);

        }

        
	}
}
