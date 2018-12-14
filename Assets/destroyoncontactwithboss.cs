using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyoncontactwithboss : MonoBehaviour {




    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Boss")

            Destroy(gameObject);

    }
}