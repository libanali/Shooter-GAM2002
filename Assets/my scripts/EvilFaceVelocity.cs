using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilFaceVelocity : MonoBehaviour {

	void Update () {


        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -17);

		
	}
}
