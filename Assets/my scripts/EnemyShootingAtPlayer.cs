using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class EnemyShootingAtPlayer : MonoBehaviour {



    public Transform TargetPlayer;

    public float playerRange;

    public GameObject EnemyBullet;

    public Transform launchpoint;

    public float GapInBetweenShots;

    private float Shotcounter;

    public AudioSource EnemyLaser;


	// Use this for initialization
	void Start () {



        TargetPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        Shotcounter = GapInBetweenShots;


		
	}
	
	// Update is called once per frame
	void Update () {

        Shotcounter -= Time.deltaTime;

        if(transform.localScale.x < 0 && TargetPlayer.transform.position.x > transform.position.x && TargetPlayer.transform.position.x < transform.position.x + playerRange && Shotcounter < 0)
        {

            Instantiate(EnemyBullet, launchpoint.position, launchpoint.rotation);
            Shotcounter = GapInBetweenShots;
            EnemyLaser.Play();

        }

        if (transform.localScale.x > 0 && TargetPlayer.transform.position.x < transform.position.x && TargetPlayer.transform.position.x > transform.position.x - playerRange && Shotcounter < 0)

        {
            Instantiate(EnemyBullet, launchpoint.position, launchpoint.rotation);
            Shotcounter = GapInBetweenShots;
            EnemyLaser.Play();
        }



    }
}
