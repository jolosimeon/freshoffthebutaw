using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class LightsOutCheckerScript : MonoBehaviour {

	float timeLeft = 5.0f;
	public Text test;

	// Use this for initialization
	void Start () {
		GameStats.Progress++;
		GameStats.CurrentLevel = 3;
		//test = GameObject.Find("test").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		//test.text = "Lights Out: " + (int) timeLeft;

		//pag di nagawa iyak
		if (timeLeft < 0) {
			GameStats.HasPassed = false;
			SceneManager.LoadScene ("ProgressScreen", LoadSceneMode.Single);
		}

		//pag nagawa niya
		if (GameStats.HasPassed) {
			SceneManager.LoadScene ("ProgressScreen", LoadSceneMode.Single);
		}

	}
}
