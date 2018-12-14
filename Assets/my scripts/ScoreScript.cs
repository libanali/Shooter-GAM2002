using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{


    public float Score;

    public float previousscore = 0;

    public Text sscore;



    void Start()
    {

        sscore = GetComponent<Text>();

        Score = 0;

    }



    void Update()
    {


        if (GetComponent<DestroyObjectOnceCOllideWithEnemy>())
        {

            Score += 1;

        }


    }

}