using UnityEngine;
using System.Collections;

public class TrashTouchDetector : MonoBehaviour {

	Ray ray;
	int numOfHitTrash=0;
	float talsikSpeed = 3.0f;

	RaycastHit hitObject;

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
				if (Physics.Raycast (ray, out hitObject, Mathf.Infinity)) {
					GameObject hitGameObject = hitObject.transform.gameObject;

					numOfHitTrash++;

					Vector3 newPos = hitGameObject.transform.position;
					while (newPos.y < 6.0) {
						newPos.y += talsikSpeed * Time.deltaTime;
						hitGameObject.transform.position = newPos;
						newPos = hitGameObject.transform.position;
					}

					Debug.Log ("HIT BAYBEH!");
				}
			}
		}

	}
}
