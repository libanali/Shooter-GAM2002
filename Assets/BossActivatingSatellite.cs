using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossActivatingSatellite : MonoBehaviour {


    public Transform TargetPlayer;

    public float playerRange;

    public GameObject Satellite;
    
    public Transform launchpointforSatellite;

    public float GapInBetweenShotsForSatellite;

    private float ShotcounterSatellite;





    // Use this for initialization
    void Start()
    {



        TargetPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        ShotcounterSatellite = GapInBetweenShotsForSatellite;




    }

    // Update is called once per frame
    void FixedUpdate()
    {


        if (GetComponent<BossHealth>().CurrentHealth <= 2000)

        {

            ShotcounterSatellite -= Time.deltaTime;

            if (transform.localScale.x < 0 && TargetPlayer.transform.position.x > transform.position.x && TargetPlayer.transform.position.x < transform.position.x + playerRange && ShotcounterSatellite < 0)
            {

                Instantiate(Satellite, launchpointforSatellite.position, launchpointforSatellite.rotation);
                ShotcounterSatellite = GapInBetweenShotsForSatellite;



            }

            if (transform.localScale.x > 0 && TargetPlayer.transform.position.x < transform.position.x && TargetPlayer.transform.position.x > transform.position.x - playerRange && ShotcounterSatellite < 0)

            {
                Instantiate(Satellite, launchpointforSatellite.position, launchpointforSatellite.rotation);
                ShotcounterSatellite = GapInBetweenShotsForSatellite;

            }



        }
    }
}