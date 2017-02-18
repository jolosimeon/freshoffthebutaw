using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverTouchDetector : MonoBehaviour {

	Ray ray;
	RaycastHit hit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			if (Input.GetTouch (0).phase == TouchPhase.Began) {
				Debug.Log ("NANIDAYO!?");
				// create and save ray from camera touch
				ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);

				// create and if collided with something
				if (Physics.Raycast (ray, out hit, Mathf.Infinity)) {

					if (hit.collider.tag == "backbtn")
						SceneManager.LoadScene ("HomeScreen", LoadSceneMode.Single);

					if (hit.collider.tag == "againbtn") {
						GameStats.CurrentLevel = 0;
						GameStats.Progress = 0;
						GameStats.LastComplete = 0;
						GameStats.Lives = 3;
						GameStats.Score = 0;

						System.Random rand = new System.Random ();
						SceneManager.LoadScene (GameStats.Levels[rand.Next(0, GameStats.Levels.Length)]);

					}

				}


			}
		}

	}
}
