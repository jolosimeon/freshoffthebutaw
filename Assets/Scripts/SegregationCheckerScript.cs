using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class SegregationCheckerScript : MonoBehaviour {

	float timeLeft = 5.0f;
	public Text test;

	// Use this for initialization
	void Start () {
		GameStats.Progress++;
		GameStats.CurrentLevel = 5;
		test = GameObject.Find("test").GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		test.text = "Segregation " + (int) timeLeft;

		//pag di nagawa iyak
		if (timeLeft < 0) {
			GameStats.HasPassed = false;
			SceneManager.LoadScene ("ProgressScreen", LoadSceneMode.Single);
		}

		//pag nagawa niya
		if (timeLeft > 99999) {
			GameStats.HasPassed = true;
			SceneManager.LoadScene ("ProgressScreen", LoadSceneMode.Single);
		}

	}
}
