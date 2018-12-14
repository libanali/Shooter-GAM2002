using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTriggerUI : MonoBehaviour
{


    public Image ObjectiveForLevel;


    void OnTriggerEnter2D(Collider2D other)

    {

        if (other.CompareTag("Player"))
        {
            ObjectiveForLevel.gameObject.SetActive(true);
        }

    }


    void OnTriggerExit2D(Collider2D other)
    {


        if (other.CompareTag("Player"))

        {
            ObjectiveForLevel.gameObject.SetActive(false);

            Destroy(gameObject);

        }
    }
}
 