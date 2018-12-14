﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthScriptForPlayer2 : MonoBehaviour {



    public int healthBonus = 25;
    public int startingHealth = 480;
    public int currentHealth;
    public Transform RespawnPoint;
    public Slider healthSlider;
    [SerializeField] public string loadlevel;



    private void Start()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(int amount)
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
        currentHealth = 200;
        healthSlider.value = currentHealth;
        SceneManager.LoadScene("Retry Health for Level 2");


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
                    currentHealth = 480;
                }
            }

            healthSlider.value = currentHealth;

        }

        if (other.gameObject.tag == "RespawnPoint")
            RespawnPoint = other.gameObject.transform;

        if(other.gameObject.tag == "Barrier")
        {
            Death();
        }
    }
}

