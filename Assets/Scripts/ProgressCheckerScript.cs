using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ProgressCheckerScript : MonoBehaviour {
    float timeLeft = 3.0f;
    Text score;
	// Use this for initialization
	void Start () {
        score = GameObject.Find("Score").GetComponent<Text>();
        
        if (GameStats.HasPassed) {
			GameStats.Score += 100;
            score.text = "" + GameStats.Score;
        } else {
			GameStats.Lives--;
            if (GameStats.Lives < 3)
                GameObject.FindGameObjectWithTag("life3").SetActive(false);
            if (GameStats.Lives < 2)
                GameObject.FindGameObjectWithTag("life2").SetActive(false);
            if (GameStats.Lives < 1)
                GameObject.FindGameObjectWithTag("life1").SetActive(false);
        }
        Debug.Log(GameStats.Lives);

		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonUp (0))
			Debug.Log ("HLLOE");
        timeLeft -= Time.deltaTime;

        if (timeLeft < 0)
        {
            if (GameStats.Lives <= 0)
                SceneManager.LoadScene("GameOverScreen", LoadSceneMode.Single);
            if (Input.touchCount > 0 || Input.GetMouseButtonDown(0))
            {
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
