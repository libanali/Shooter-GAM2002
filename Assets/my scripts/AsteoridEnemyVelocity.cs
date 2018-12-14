using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteoridEnemyVelocity : MonoBehaviour
{


     void Update()
    {

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 8);

    }

}
