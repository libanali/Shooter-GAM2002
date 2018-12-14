using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealthPackActivation : MonoBehaviour {




    public Transform TargetPlayer;

    public float playerRange;

    public GameObject HPACK;

    public Transform launchpointforHPACK;
    
    public float GapInBetweenShotsForHPACK;

    private float ShotcounterHPACK;


    

    // Use this for initialization
    void Start()
    {



        TargetPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        ShotcounterHPACK = GapInBetweenShotsForHPACK;




    }

    // Update is called once per frame
    void Update()
    {

        ShotcounterHPACK -= Time.deltaTime;

        if (transform.localScale.x < 0 && TargetPlayer.transform.position.x > transform.position.x && TargetPlayer.transform.position.x < transform.position.x + playerRange && ShotcounterHPACK < 0)
        {

            Instantiate(HPACK, launchpointforHPACK.position, launchpointforHPACK.rotation);
            ShotcounterHPACK = GapInBetweenShotsForHPACK;



        }

        if (transform.localScale.x > 0 && TargetPlayer.transform.position.x < transform.position.x && TargetPlayer.transform.position.x > transform.position.x - playerRange && ShotcounterHPACK < 0)

        {
            Instantiate(HPACK, launchpointforHPACK.position, launchpointforHPACK.rotation);
            ShotcounterHPACK = GapInBetweenShotsForHPACK;

        }



    }
}
