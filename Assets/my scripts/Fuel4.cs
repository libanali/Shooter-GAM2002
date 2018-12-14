using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fuel4 : MonoBehaviour {





    public float FuelBonus = 25;
    public float startingFuel = 1500;
    public float currentFuel;
    public Transform RespawnPoint;
    public Slider FuelSlider;
    [SerializeField] public string loadlevel;
    public Text DangerDangerDanger;



    private void Start()
    {
        currentFuel = startingFuel;
    }

    public void TakeSomeFuel(float amount)
    {
        // GetComponent<newplayermovement>();

        currentFuel -= amount;
        FuelSlider.value = currentFuel;

        if (currentFuel <= 0)
        {
            Death();
        }
    }


    void Death()
    {

        transform.position = RespawnPoint.transform.position;
        currentFuel = startingFuel;
        SceneManager.LoadScene("Retry Fuel for Boss");


    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "FuelPack")
        {
            if (currentFuel < startingFuel)
            {
                Destroy(other.gameObject);
                currentFuel += FuelBonus;
                if (currentFuel > startingFuel)
                {
                    currentFuel = 1500;
                }
            }

            FuelSlider.value = currentFuel;

        }

        if (other.gameObject.tag == "RespawnPoint")
        {
            RespawnPoint = other.gameObject.transform;
        }
    }



    void LowFuel()
    {


        if (currentFuel <= 100)
        {

            DangerDangerDanger.gameObject.SetActive(true);

        }

    }
}


   




	

