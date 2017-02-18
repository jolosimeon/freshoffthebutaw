using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HomeTouchCheckerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameStats.CurrentLevel = 0;
		GameStats.Progress = 0;
		GameStats.LastComplete = 0;
		GameStats.Lives = 3;
		GameStats.Score = 0;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp (0))
			Debug.Log ("HLLOE");
		if (Input.touchCount > 0 || Input.GetMouseButtonDown(0)) {
			Debug.Log ("JUST LIKE TT");
			System.Random rand = new System.Random ();
			SceneManager.LoadScene (GameStats.Levels[rand.Next(0, GameStats.Levels.Length)]);
			//SceneManager.LoadScene ("ProgressScreen", LoadSceneMode.Single);
		}

	}
}
