using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovingforNEWDIMENSION2 : MonoBehaviour {

    private void Update()
    {

        GetComponent<Rigidbody2D>().velocity = new Vector2(-50, 0);

    }

}
