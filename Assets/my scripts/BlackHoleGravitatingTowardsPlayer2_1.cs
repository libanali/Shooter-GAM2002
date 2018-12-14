﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleGravitatingTowardsPlayer2_1 : MonoBehaviour {
    public float speed;
    public float stoppingDistance;

    private Transform target;



    void Start()
    {


        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    void Update()
    {

        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {

            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        }

    }

}