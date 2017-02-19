using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HomeTouchCheckerScript : MonoBehaviour {
	float timeLeft = 1.5f;

	// Use this for initialization
	void Start () {
		GameStats.CurrentLevel = 0;
		GameStats.Progress = 0;
		GameStats.LastComplete = 0;
		GameStats.Lives = 3;
		GameStats.Score = 0;
		GameStats.HasPassed = false;

		if (GameStats.HealthState == 1)
			GameObject.Find ("healthy earth").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("healthy earth");
		else
			GameObject.Find ("healthy earth").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite> ("sick earth");
	}

	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {
		if (Input.touchCount > 0 || Input.GetMouseButtonDown(0)) {
			Debug.Log ("JUST LIKE TT");
			System.Random rand = new System.Random ();
			SceneManager.LoadScene (GameStats.Levels[rand.Next(0, GameStats.Levels.Length)]);
			//SceneManager.LoadScene ("ProgressScreen", LoadSceneMode.Single);
			}
		}

	}
}
