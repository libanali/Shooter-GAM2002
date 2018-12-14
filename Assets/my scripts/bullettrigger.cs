using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullettrigger : MonoBehaviour {



    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        Destroy(gameObject);

    }
    }
