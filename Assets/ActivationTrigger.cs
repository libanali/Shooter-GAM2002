using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationTrigger : MonoBehaviour
{



    private int Aindex = 0;
    public GameObject[] Enemies;
    private bool activate = false;

    private float timer;
    private float SpawnGap = 1.5f;
    private bool settimer = false;




    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            activate = true;
        }
    }

    private void Update()
    {
        if (activate)
        {

            if (!settimer)
            {
                timer = Time.time + SpawnGap;
                settimer = true;

            }

            if (timer <= Time.time)
            {
                SpawnEnemy();
                Aindex += 1;
                if (Enemies.Length < Aindex)
                {
                    activate = false;
                }
            }
        }
        if (timer > Time.time) { settimer = false; }
    }

    private void SpawnEnemy()
    {

        Enemies[Aindex].SetActive(true);
    }
}
