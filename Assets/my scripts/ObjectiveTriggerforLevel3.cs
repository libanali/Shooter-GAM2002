using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveTriggerforLevel3 : MonoBehaviour
{


    public Image Objectiveee;


    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {

            Objectiveee.gameObject.SetActive(true);
        }


    }


    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {

            Objectiveee.gameObject.SetActive(false);
            Destroy(gameObject);

        }

    }
}

