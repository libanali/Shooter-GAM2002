using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateEnemy1 : MonoBehaviour {



    public GameObject[] Enemies;
    public int Aindex = 0;
    

  


    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.gameObject.tag == "Player")
        {

            Enemies[Aindex].SetActive(true);

        }

    }
}
