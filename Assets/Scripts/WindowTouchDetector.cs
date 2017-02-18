using UnityEngine;
using System.Collections;

public class WindowTouchDetector : MonoBehaviour {

	Ray ray;
	int numOfOffRooms=0;

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
				if (Physics.Raycast (ray, Mathf.Infinity)) {
					numOfOffRooms++;
					Debug.Log ("HIT BAYBEH!");
				}
			}
		}

		// inform gamestats that IZZ DAN
		if (numOfOffRooms == 4) {
			
		}

	}
}
