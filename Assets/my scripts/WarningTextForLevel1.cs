using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WarningTextForLevel1 : MonoBehaviour
{



    public GameObject image; 



    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {

            image.gameObject.SetActive(true);
        }


    }



    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            image.gameObject.SetActive(false);

            Destroy(gameObject);
        }


    }

}
