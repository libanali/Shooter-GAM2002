using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTONextScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void NextGoToUpgradeMenu1()
    {
        SceneManager.LoadScene("Upgrade Menu");
    }

    public void GoToLevel2()
    {
        SceneManager.LoadScene("Gam Level 2");
    }


    public void GoToUppgradeMenu2()

    {

        SceneManager.LoadScene("Upgrade Menu 2");
    }

    public void GoToInfoAboutPlayerHealth()

    {
        SceneManager.LoadScene("Information about Playerhealth");
    }


    public void GoToInfoAboutPlayerFuel()

    {
        SceneManager.LoadScene("Informaiton about PlayerFuel");
    }

    public void GoToInfoAboutEnemies() 

    {
        SceneManager.LoadScene("Information about Enemies");
    }

    public void GoToGame()

    {
        SceneManager.LoadScene("Gam Level 1");
    }

    public void GoToInfoAboutItems() {

        SceneManager.LoadScene("Information about Items");
    }

    public void QuitMainMenu() 
    {

        Application.Quit();

    }

    public void OnToLevel3() {

        SceneManager.LoadScene("Gam Level 3");

    }

    public void OnToWarningAboutBlackHole()

    {
        SceneManager.LoadScene("Explaining the black hole");
    }

    public void OntoExplainingShooting()
    {

        SceneManager.LoadScene("ShootingInfo");
    }

    public void GoToMainMenu() {

        SceneManager.LoadScene("Main Menu");
    }


    public void GoToCongratsScreen() {

        SceneManager.LoadScene("Congratulations!");

    }

    public void GoToCredits() {


        SceneManager.LoadScene("Credits");

    }

    public void GoToEnemyShootingGuide(){


        SceneManager.LoadScene("Information About Enemies Shooting");

    }


    public void GoToBonusStage() {

        SceneManager.LoadScene("Bonus Stage");
    }


    public void GoToBarrierWarning()
    {

        SceneManager.LoadScene("Barrier Warning");
    }


    public void GoToInfoAboutBoss() {


        SceneManager.LoadScene("Information About Boss");


    }



    public void GoToMovementInfo()
    {


        SceneManager.LoadScene("Movement");


    }

}
