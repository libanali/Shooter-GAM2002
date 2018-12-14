using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToLevel3 : MonoBehaviour {


    [SerializeField] private string loadlevel;

	
    void OnTriggerEnter2D (Collider2D other) {


        if(other.CompareTag("Player"))
        {

            SceneManager.LoadScene("Gam Level 3");
        }




		
	}
}
