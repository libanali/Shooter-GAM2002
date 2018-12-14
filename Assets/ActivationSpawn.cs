using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationSpawn : MonoBehaviour {



    public GameObject[] enemies;
    public int Aindex = 0;
    Vector3 WhereToSpawn;
    float RandX;
    [SerializeField]
    private float SpawnDelay = 1;
    private float counter;
    private bool spawnIn;




    void OnTriggerEnter2D(Collider2D other)

    {



        if (other.gameObject.tag == "Player")
        {

            enemies[Aindex].SetActive(true);

        }

    }




    private void Update()
    {

        if (!spawnIn && Time.time >= counter)


        {

            RandX = Random.Range(850f, -1400f);
            Aindex = Random.Range(0, enemies.Length);
            WhereToSpawn = new Vector3(RandX, transform.position.y, -1);
            Instantiate(enemies[Aindex], WhereToSpawn, Quaternion.identity);
            counter -= Time.deltaTime;
            spawnIn = true;
            counter = Time.time + SpawnDelay;


        }

        if (spawnIn && Time.time >= counter)
        {
            spawnIn = false;

        }
    }

}