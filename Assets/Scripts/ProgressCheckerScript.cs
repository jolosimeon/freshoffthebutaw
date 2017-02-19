using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ProgressCheckerScript : MonoBehaviour {
    float timeLeft = 1.0f;
	float timeInterval = 5.0f;
    Text score;
	Text factText;

	string[] factList = new string[5];

	// Use this for initialization
	void Start () {

		// populate facts
		factList[0] = "Recycling paper, plastic, glass & aluminium keeps landfills from growing.";
		factList[1] = "Use a refillable water bottle and plastic cup. Cut down on waste and maybe even save money for your barkada trips!";
		factList[2] = "Speak up! Ask your local and national authorities to engage in initiatives that don't harm people or the planet.";
		factList[3] = "Shop local, support local, BE LOCAL!";
		factList[4] = "Bike, walk or take public transport. Save the car trips for your gala to Tagaytay!";

		System.Random rand = new System.Random ();
		int num = rand.Next (0, factList.Length);

		factText = GameObject.Find("facts").GetComponent<Text>();
		factText.text = factList [num];

        score = GameObject.Find("Score").GetComponent<Text>();
        
		if (GameStats.HasPassed) {
			GameStats.Score += 100;
            
		} else {
			GameStats.Lives--;
		}
            if (GameStats.Lives < 3)
                GameObject.FindGameObjectWithTag("life3").SetActive(false);
            if (GameStats.Lives < 2)
                GameObject.FindGameObjectWithTag("life2").SetActive(false);
            if (GameStats.Lives < 1)
                GameObject.FindGameObjectWithTag("life1").SetActive(false);
        Debug.Log(GameStats.Lives);
		score.text = "" + GameStats.Score;
		
	}
	
	// Update is called once per frame
	void Update () {

        timeLeft -= Time.deltaTime;
		/*timeInterval -= Time.deltaTime;

		if (timeInterval < 0) {
			timeInterval = 3.0f;
			factText.CrossFadeAlpha (0.0f, 1.5f, false);
			factText.text = factList [index];
			index++;
			if (index == factList.Length)
				index = 0;
			factText.CrossFadeAlpha (2.0f, 0.05f, false);
		}*/

        if (timeLeft < 0)
        {
            
            if (Input.touchCount > 0 || Input.GetMouseButtonDown(0))
            {
				if (GameStats.Lives <= 0)
					SceneManager.LoadScene("GameOverScreen", LoadSceneMode.Single);
				else {
	                GameStats.HasPassed = false;
	                System.Random rand = new System.Random();
	                int nextLevel = GameStats.Levels[rand.Next(0, GameStats.Levels.Length)];
	                while (nextLevel == GameStats.CurrentLevel)
	                    nextLevel = GameStats.Levels[rand.Next(0, GameStats.Levels.Length)];
	                SceneManager.LoadScene(nextLevel);
	                //SceneManager.LoadScene ("ProgressScreen", LoadSceneMode.Single);
				}
            }
        }
	
	}
}
