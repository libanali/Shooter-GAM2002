using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneVelocityForDimension2 : MonoBehaviour {


	
    void Update () {


        GetComponent<Rigidbody2D>().velocity = new Vector2(18, 0);

		
	}
}
