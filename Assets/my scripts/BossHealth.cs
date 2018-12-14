using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class BossHealth : MonoBehaviour
{


    public int CurrentHealth = 7000;

    public int StartingHealth;

    public Slider HealthBar;

    public GameObject hpack;

    public AudioSource BossBattle;

    public AudioSource Victory;

    public Text YouDidIt;

    public GameObject VelocityTrigger;
    



    // Use this for initialization
    void Start()
    {

        CurrentHealth = 7000;

        CurrentHealth = StartingHealth;

    }



    public void TakingDamage(int amount)
    {

        CurrentHealth -= amount;

        HealthBar.value = CurrentHealth;

        if (CurrentHealth <= 0)
        {

            Death();
        }


    }



     public void Death()
    {

        BossBattle.Stop();

        Victory.Play();

        Destroy(gameObject);

        HealthBar.gameObject.SetActive(false);

        YouDidIt.gameObject.SetActive(true);

        VelocityTrigger.SetActive(true);


    }
}





