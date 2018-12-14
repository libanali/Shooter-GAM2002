using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidEnemyVelocityForNewDimension2 : MonoBehaviour {

	
	void Update () {


        GetComponent<Rigidbody2D>().velocity = new Vector2(-4, 0);

	}
}
