﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateEnemy3 : MonoBehaviour {




    public GameObject[] Enemies3;

    private int Aindex = 0;



    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {

            Enemies3[Aindex].SetActive(true);
        }
    }
}