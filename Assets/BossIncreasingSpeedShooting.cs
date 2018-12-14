using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossIncreasingSpeedShooting : MonoBehaviour {



    public Transform TargetPlayer;

    public float playerRange;

    public GameObject EnemyBullet;

    public Transform launchpointNEWBULLET;

    public Transform launchpointNEWBULLET2;

    public float GapInBetweenShotsForEnemyBullet;

    private float Shotcounter;

    public AudioSource EnemyLaser;


    // Use this for initialization
    void Start()
    {



        TargetPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        Shotcounter = GapInBetweenShotsForEnemyBullet;




    }

    // Update is called once per frame
    void FixedUpdate()


    {

        if(GetComponent<BossHealth>().CurrentHealth <= 3900)

        Shotcounter -= Time.deltaTime;

        if (transform.localScale.x < 0 && TargetPlayer.transform.position.x > transform.position.x && TargetPlayer.transform.position.x < transform.position.x + playerRange && Shotcounter < 0)
        {

            Instantiate(EnemyBullet, launchpointNEWBULLET.position, launchpointNEWBULLET.rotation);
            Instantiate(EnemyBullet, launchpointNEWBULLET2.position, launchpointNEWBULLET2.rotation);
            Shotcounter = GapInBetweenShotsForEnemyBullet;
            EnemyLaser.Play();



        }

        if (transform.localScale.x > 0 && TargetPlayer.transform.position.x < transform.position.x && TargetPlayer.transform.position.x > transform.position.x - playerRange && Shotcounter < 0)

        {
            Instantiate(EnemyBullet, launchpointNEWBULLET.position, launchpointNEWBULLET.rotation);
            Instantiate(EnemyBullet, launchpointNEWBULLET2.position, launchpointNEWBULLET2.rotation);

            Shotcounter = GapInBetweenShotsForEnemyBullet;
            EnemyLaser.Play();

        }



    }
}
