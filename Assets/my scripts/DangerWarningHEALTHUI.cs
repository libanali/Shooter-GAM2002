using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class DangerWarningHEALTHUI : MonoBehaviour
{


    public Text Dangerwarning;

    public AudioSource HealthAlertt;




    // Use this for initialization
    void Start()
    {


        Dangerwarning.gameObject.SetActive(false);



        
    }




    void LowHealth()
    {



        if (GetComponent<HealthScriptForPlayer>().currentHealth <= 100)

        {

            Dangerwarning.gameObject.SetActive(true);

            HealthAlertt.Play();


        }

        else
        {

            Dangerwarning.gameObject.SetActive(false);

            HealthAlertt.Pause();
        }


    }



    private void Update()
    {

        LowHealth();

    }
}
	