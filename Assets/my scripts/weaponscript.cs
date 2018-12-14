using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class weaponscript : MonoBehaviour {

    public Transform FirePoint;
    public GameObject bullet;
    public AudioSource LaserSound;








    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0)) 
        {
            

            Shoot();

            LaserSound.Play();



        }
    }


        void Shoot()
        {

            Instantiate(bullet, FirePoint.position, FirePoint.rotation);

        }


	}

