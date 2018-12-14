using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paperplane : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {


        GetComponent<Rigidbody2D>().velocity = new Vector2(80, 0);
		
	}
}
