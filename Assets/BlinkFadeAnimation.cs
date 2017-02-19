using UnityEngine;
using System.Collections;

public class BlinkFadeAnimation : MonoBehaviour {

	public float minimum = 0.0f;
	public float maximum = 1f;
	public float duration = 3.0f;
	private float startTime;
	public SpriteRenderer sprite;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		float t = (Time.time - startTime) / duration;
		sprite.color = new Color (1f, 1f, 1f, Mathf.SmoothStep (minimum, maximum, t));
	}
}
