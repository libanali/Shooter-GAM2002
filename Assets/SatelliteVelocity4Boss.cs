﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatelliteVelocity4Boss : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -70);
		
	}
}
