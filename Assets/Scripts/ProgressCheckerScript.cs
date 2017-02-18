using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ProgressCheckerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (GameStats.HasPassed) {
			GameStats.Score += 100;
		} else {
			GameStats.Lives--;
		}

		if (GameStats.Lives == 0)
			SceneManager.LoadScene ("GameOverScreen", LoadSceneMode.Single);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonUp (0))
			Debug.Log ("HLLOE");

		if (Input.touchCount > 0 || Input.GetMouseButtonDown(0)) {
			System.Random rand = new System.Random ();
			int nextLevel = GameStats.Levels [rand.Next (0, GameStats.Levels.Length)];
			while (nextLevel == GameStats.CurrentLevel)
				nextLevel = GameStats.Levels [rand.Next (0, GameStats.Levels.Length)];
			SceneManager.LoadScene (nextLevel);
			//SceneManager.LoadScene ("ProgressScreen", LoadSceneMode.Single);
		}
	
	}
}
