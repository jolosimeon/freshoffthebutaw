using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class SmokeCheckerScript : MonoBehaviour {
	float timeLeft = 6.0f;
    int totalTaps = 0;

	Text timeText;
	//public Text test;

	// Use this for initialization
	void Start () {
		GameStats.Progress++;
		GameStats.CurrentLevel = 6;
		//test = GameObject.Find("test").GetComponent<Text>();
		timeText = GameObject.Find("Score").GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
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

        if (Input.touchCount > 0 || Input.GetMouseButtonDown(0))
        {
            Debug.Log("gg na ph0wz");
            totalTaps++;
            if (totalTaps > 50)
            {
                GameObject WorldHolderGameObject = GameObject.Find("WorldHolder");
                WorldHolderGameObject.transform.FindChild("med").gameObject.SetActive(true);
            }
            if (totalTaps > 80)
            {
                GameObject.Find("med").SetActive(false);
                GameObject WorldHolderGameObject = GameObject.Find("WorldHolder");
                WorldHolderGameObject.transform.FindChild("big").gameObject.SetActive(true);
            }
            if (totalTaps > 90)
                GameStats.HasPassed = true;
            GameObject.Find("smog1").transform.Translate(new Vector3((float) -0.08, 0, 0));
            GameObject.Find("smog2").transform.Translate(new Vector3((float)0.11, 0, 0));
            GameObject.Find("smog3").transform.Translate(new Vector3((float)0.17, 0, 0));
            //System.Random rand = new System.Random();
            //SceneManager.LoadScene(GameStats.Levels[rand.Next(0, GameStats.Levels.Length)]);
            //SceneManager.LoadScene ("ProgressScreen", LoadSceneMode.Single);
        }



    }
}
