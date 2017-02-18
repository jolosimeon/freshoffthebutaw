using UnityEngine;
using System.Collections;

public class WindowTouchDetector : MonoBehaviour {

	Ray ray;
	int numOfOffRooms=0;

	RaycastHit hitObject;

	public Sprite window_light_on;
	public Sprite window_light_off;
	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		window_light_on = Resources.Load<Sprite> ("window_light_on");
		window_light_off = Resources.Load<Sprite>("window_light_off");
	}

	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			if (Input.GetTouch (0).phase == TouchPhase.Began) {
				Debug.Log ("NANIDAYO!?");
				// create and save ray from camera touch
				ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);

				// create and if collided with something
				if (Physics.Raycast (ray, out hitObject, Mathf.Infinity)) {
					GameObject hitGameObject = hitObject.transform.gameObject;

					spriteRenderer = hitGameObject.GetComponent<SpriteRenderer> ();
					if (spriteRenderer.sprite == window_light_on) {
						spriteRenderer.sprite = window_light_off;
						numOfOffRooms++;
					} else {
						spriteRenderer.sprite = window_light_on;
						numOfOffRooms--;
					}

					Debug.Log ("HIT BAYBEH!");
				}
			}
		}

		// inform gamestats that IZZ DAN
		if (numOfOffRooms == 4) {
			GameStats.HasPassed = true;
		}

	}
}
