using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DangerWarningFUELUIforboss : MonoBehaviour {

    public Text DangerwarningFuel4boss;



	// Use this for initialization
	void Start () {

        
        DangerwarningFuel4boss.gameObject.SetActive(false);


		
	}
	
	// Update is called once per frame
	void Update () {



        if(GetComponent<Fuel4>().currentFuel <= 400)
        {

            DangerwarningFuel4boss.gameObject.SetActive(true);
            
        }

        else
        {

            DangerwarningFuel4boss.gameObject.SetActive(false);
        }


		
	}
}
