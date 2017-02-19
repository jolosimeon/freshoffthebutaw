using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class RunderwaterCheckerScript : MonoBehaviour {

	float timeLeft = 5.0f;
	public Text timeText;

	// Use this for initialization
	void Start () {
		GameStats.Progress++;
		GameStats.CurrentLevel = 4;
		timeText = GameObject.Find("Score").GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		if (timeLeft - Time.deltaTime < 0)
			timeLeft = 0;
		else
			timeLeft -= Time.deltaTime;
		timeText.text = ""+(int)System.Math.Round(timeLeft,2);

		//pag di nagawa iyak
		if (timeLeft == 0) {
			GameStats.HasPassed = false;
			SceneManager.LoadScene ("ProgressScreen", LoadSceneMode.Single);
		}

		//pag nagawa niya
		if (GameStats.HasPassed) {
			SceneManager.LoadScene ("ProgressScreen", LoadSceneMode.Single);
		}

	}
}
