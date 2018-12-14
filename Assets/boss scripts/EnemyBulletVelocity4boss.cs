using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletVelocity4boss : MonoBehaviour {

	
	void Update () {

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -19);
		
	}
}
