using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackHoleNextDimensionTrigger : MonoBehaviour
{





    [SerializeField] private string LoadLevel;



    void OnTriggerEnter2D(Collider2D other) {
    


        if (other.CompareTag("Player"))
        {

            SceneManager.LoadScene("NewDimesion1");

            Destroy(gameObject);






    }
    }

}