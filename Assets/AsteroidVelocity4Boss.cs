using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidVelocity4Boss : MonoBehaviour {

	// Update is called once per frame
	void Update () {


        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -83);

		
	}
}
