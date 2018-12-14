using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfLevelTriggerForLevel3 : MonoBehaviour
{


    [SerializeField] private string loadlevel;



    private void OnTriggerEnter2D(Collider2D other)

    {

        if (other.CompareTag("Player"))
        {

            SceneManager.LoadScene("Victory3");
        }

    }
}
        



