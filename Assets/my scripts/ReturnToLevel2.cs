using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToLevel2 : MonoBehaviour
{



    [SerializeField] private string LoadLevel;




    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.CompareTag("Player"))
        {

            SceneManager.LoadScene("Gam Level 2");

        }

    }

}