using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class SmokeCheckerScript : MonoBehaviour {
	float timeLeft = 7.0f;
    int totalTaps = 0;
	//public Text test;

	// Use this for initialization
	void Start () {
		GameStats.Progress++;
		GameStats.CurrentLevel = 6;
		//test = GameObject.Find("test").GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		//test.text = "Smoke: " + (int) timeLeft;

		//pag di nagawa iyak
		if (timeLeft < 0) {
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
            if (totalTaps > 15)
            {
                GameObject WorldHolderGameObject = GameObject.Find("WorldHolder");
                WorldHolderGameObject.transform.FindChild("med").gameObject.SetActive(true);
            }
            if (totalTaps > 25)
            {
                GameObject.Find("med").SetActive(false);
                GameObject WorldHolderGameObject = GameObject.Find("WorldHolder");
                WorldHolderGameObject.transform.FindChild("big").gameObject.SetActive(true);
            }
            if (totalTaps > 30)
                GameStats.HasPassed = true;
            GameObject.Find("smog1").transform.Translate(new Vector3((float) -0.13, 0, 0));
            GameObject.Find("smog2").transform.Translate(new Vector3((float)0.15, 0, 0));
            GameObject.Find("smog3").transform.Translate(new Vector3((float)0.22, 0, 0));
            //System.Random rand = new System.Random();
            //SceneManager.LoadScene(GameStats.Levels[rand.Next(0, GameStats.Levels.Length)]);
            //SceneManager.LoadScene ("ProgressScreen", LoadSceneMode.Single);
        }



    }
}
