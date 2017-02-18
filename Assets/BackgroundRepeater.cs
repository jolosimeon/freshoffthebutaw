using UnityEngine;
using System.Collections;

public class BackgroundRepeater : MonoBehaviour {

	int spriteLimit = 15;
	float movementSpeed = 1.0f;

	void Start() {
		
	}
	void Update() {
		if ((transform.position.x < spriteLimit)) {
			Vector3 newPos = transform.position;
			newPos.x += movementSpeed*Time.deltaTime;
			transform.position = newPos;
		} else {
			Vector3 newPos = new Vector3(-30.0f, 0.0f, 0.0f);
			transform.position = newPos;
		}
	}
}