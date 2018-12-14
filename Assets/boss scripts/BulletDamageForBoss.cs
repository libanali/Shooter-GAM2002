using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class BulletDamageForBoss : MonoBehaviour
{



    public int Damage = 25;

    public AudioSource grunt;

     void OnCollisionEnter2D(Collision2D collision)

    {

        if(collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Boss")
        {

            BossHealth _Boss = collision.gameObject.GetComponent<BossHealth>();

            _Boss.TakingDamage(Damage);

            grunt.Play();

        }
        
    }


}