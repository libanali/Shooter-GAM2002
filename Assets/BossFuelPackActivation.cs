using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFuelPackActivation : MonoBehaviour {


    public Transform TargetPlayer;

    public float playerRange;

    public GameObject FPACK;
    
    public Transform launchpointforFPACK;

    public float GapInBetweenShotsForFPACK;


    private float ShotcounterFPACK;





    // Use this for initialization
    void Start()
    {



        TargetPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        ShotcounterFPACK = GapInBetweenShotsForFPACK;




    }

    // Update is called once per frame
    void Update()
    {

        ShotcounterFPACK -= Time.deltaTime;

        if (transform.localScale.x < 0 && TargetPlayer.transform.position.x > transform.position.x && TargetPlayer.transform.position.x < transform.position.x + playerRange && ShotcounterFPACK < 0)
        {

            Instantiate(FPACK, launchpointforFPACK.position, launchpointforFPACK.rotation);
            ShotcounterFPACK = GapInBetweenShotsForFPACK;



        }

        if (transform.localScale.x > 0 && TargetPlayer.transform.position.x < transform.position.x && TargetPlayer.transform.position.x > transform.position.x - playerRange && ShotcounterFPACK < 0)

        {
            Instantiate(FPACK, launchpointforFPACK.position, launchpointforFPACK.rotation);
            ShotcounterFPACK = GapInBetweenShotsForFPACK;

        }



    }
}

