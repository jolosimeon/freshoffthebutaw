using UnityEngine;
using System.Collections;

public class BounceTitle : MonoBehaviour
{
	public bool Move = true;    ///gives you control in inspector to trigger it or not
	public Vector3 MoveVector = Vector3.up; //unity already supplies us with a readonly vector representing up and we are just chaching that into MoveVector
	public float MoveRange = 0.1f; //change this to increase/decrease the distance between the highest and lowest points of the bounce
	public float MoveSpeed = 3.0f; //change this to make it faster or slower

	private BounceTitle bounceObject; //for caching this transform

	Vector3 startPosition; //used to cache the start position of the transform
	void Start()
	{ 
		bounceObject = this;
		startPosition = bounceObject.transform.position;
	}
	void Update()
	{
		if(Move) //bool is checked
			//See if you can work out whats going on here, for your own enjoyment
			bounceObject.transform.position = startPosition + MoveVector * (MoveRange * Mathf.Sin(Time.timeSinceLevelLoad * MoveSpeed));

	}
}