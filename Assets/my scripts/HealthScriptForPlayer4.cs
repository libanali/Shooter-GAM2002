using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthScriptForPlayer4 : MonoBehaviour {



    public int healthBonus = 25;
    public int startingHealth = 900;
    public int currentHealth;
    public Transform RespawnPoint;
    public Slider healthSlider;
    [SerializeField] public string loadlevel;



    private void Start()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamgeee(int amount)
    {

        currentHealth -= amount;
        healthSlider.value = currentHealth;

        if (currentHealth <= 0)
        {
            Death();
        }
    }


    void Death()
    {

        transform.position = RespawnPoint.transform.position;
        currentHealth = 700;
        healthSlider.value = currentHealth;
        SceneManager.LoadScene("Retry Healh for boss");


    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "HealthPack")
        {
            if (currentHealth < startingHealth)
            {
                Destroy(other.gameObject);
                currentHealth += healthBonus;
                if (currentHealth > startingHealth)
                {
                    currentHealth = 900;
                }
            }

            healthSlider.value = currentHealth;

        }

        if (other.gameObject.tag == "RespawnPoint")
            RespawnPoint = other.gameObject.transform;

        {

            if(other.gameObject.tag == "Barrier")
            {
                Death();
            }

        }
    }
}




