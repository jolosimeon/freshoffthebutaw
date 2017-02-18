using UnityEngine;
using System.Collections;

public class BackgroundKelpRepeater : MonoBehaviour {

	int spriteLimit = -15;
	float movementSpeed = 1.0f;

	void Start() {

	}
	void Update() {
		if ((transform.position.x > spriteLimit)) {
			Vector3 newPos = transform.position;
			newPos.x -= movementSpeed*Time.deltaTime;
			transform.position = newPos;
		} else {
			Vector3 newPos = new Vector3(51.75f, 3.78f, 0.0f);
			transform.position = newPos;
		}
	}
}
