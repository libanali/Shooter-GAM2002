using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockpos : MonoBehaviour {


    float lockposition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.rotation = Quaternion.Euler(lockposition, lockposition, lockposition);

	}
}
