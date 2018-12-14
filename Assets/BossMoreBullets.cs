using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMoreBullets : MonoBehaviour {

    public Transform TargetPlayer;

    public float playerRange;

    public GameObject MoreBullets;

    public Transform launchpointformorebullets;

    public float GapInBetweenShotsFormorebullets;

    private float Shotcountermorebullets;





    // Use this for initialization
    void Start()
    {



        TargetPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        Shotcountermorebullets = GapInBetweenShotsFormorebullets;




    }

    // Update is called once per frame
    void FixedUpdate()
    {


        if (GetComponent<BossHealth>().CurrentHealth <= 1000)

        {

            Shotcountermorebullets -= Time.deltaTime;

            if (transform.localScale.x < 0 && TargetPlayer.transform.position.x > transform.position.x && TargetPlayer.transform.position.x < transform.position.x + playerRange && Shotcountermorebullets < 0)
            {

                Instantiate(MoreBullets, launchpointformorebullets.position, launchpointformorebullets.rotation);
                Shotcountermorebullets = GapInBetweenShotsFormorebullets;



            }

            if (transform.localScale.x > 0 && TargetPlayer.transform.position.x < transform.position.x && TargetPlayer.transform.position.x > transform.position.x - playerRange && Shotcountermorebullets < 0)

            {
                Instantiate(MoreBullets, launchpointformorebullets.position, launchpointformorebullets.rotation);
                Shotcountermorebullets = GapInBetweenShotsFormorebullets;

            }



        }
    }
}
