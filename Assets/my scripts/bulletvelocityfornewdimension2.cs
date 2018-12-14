using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletvelocityfornewdimension2 : MonoBehaviour {


    void Update()
    {

        GetComponent<Rigidbody2D>().velocity = new Vector2(60, 0);
    }
		
	}

