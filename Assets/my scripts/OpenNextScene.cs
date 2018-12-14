using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenNextScene : MonoBehaviour {

    // Use this for initialization



    public void PlayScene()
    {


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);

    }
   
}
