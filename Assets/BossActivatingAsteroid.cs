using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossActivatingAsteroid : MonoBehaviour
{



    public Transform TargetPlayer;

    public float playerRange;

    public GameObject Asteroid;

    public Transform launchpointforAsteroid;

    public float GapInBetweenShotsForAsteroid;


    private float ShotcounterAsteroid;





    // Use this for initialization
    void Start()
    {



        TargetPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        ShotcounterAsteroid = GapInBetweenShotsForAsteroid;




    }

    // Update is called once per frame
    void FixedUpdate()
    {


        if (GetComponent<BossHealth>().CurrentHealth <= 2500)

        {

            ShotcounterAsteroid -= Time.deltaTime;

            if (transform.localScale.x < 0 && TargetPlayer.transform.position.x > transform.position.x && TargetPlayer.transform.position.x < transform.position.x + playerRange && ShotcounterAsteroid < 0)
            {

                Instantiate(Asteroid, launchpointforAsteroid.position, launchpointforAsteroid.rotation);
                ShotcounterAsteroid = GapInBetweenShotsForAsteroid;



            }

            if (transform.localScale.x > 0 && TargetPlayer.transform.position.x < transform.position.x && TargetPlayer.transform.position.x > transform.position.x - playerRange && ShotcounterAsteroid < 0)

            {
                Instantiate(Asteroid, launchpointforAsteroid.position, launchpointforAsteroid.rotation);
                ShotcounterAsteroid = GapInBetweenShotsForAsteroid;

            }



        }
    }
}