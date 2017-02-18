using UnityEngine;
using System.Collections;

public class EarthRotation : MonoBehaviour {

	float rotationsPerMinute = 0.3f;

	// Use this for initialization
	void Start () {
	
	}

	void Update()
	{
		transform.Rotate(0.0f,0.0f,6.0f*rotationsPerMinute*Time.deltaTime);
	}
}
