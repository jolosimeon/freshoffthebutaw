using UnityEngine;
using System.Collections;

public class UnderwaterTrashController : MonoBehaviour {


	float movementSpeed = 2.0f;
	float talsikSpeed = 3.0f;
	float rotationsPerMinuteTrash = 1.0f;

	bool ifMoveLeft = true;

	// Use this for initialization
	void Start () {

		Sprite[] sprites = new Sprite[6];
		sprites[0] = Resources.Load<Sprite>("apple");
		sprites[1] = Resources.Load<Sprite>("banana");
		sprites[2] = Resources.Load<Sprite>("bottle");
		sprites[3] = Resources.Load<Sprite>("can");
		sprites[4] = Resources.Load<Sprite>("chips");
		sprites[5] = Resources.Load<Sprite>("plasticbag");

		//for (int i = 0; i < 5; i++) {
			System.Random rand = new System.Random ();
			int num = rand.Next (0, sprites.Length);
			//objects [i].GetComponent<SpriteRenderer> ().sprite = sprites [num];
		transform.GetComponent<SpriteRenderer> ().sprite = sprites [num];

			//rand = new System.Random ();
		float numX = (float)GetRandomNumber(4.0, 7.5);
			//rand = new System.Random ();
		float numY = (float)GetRandomNumber(-1.9, 3.06);
			transform.position = new Vector3(numX, numY, 0.0f);
		//}
		
	}
	
	// Update is called once per frame
	void Update () {

		if (ifMoveLeft) {
			Debug.Log ("KOKUSAI");
			Vector3 newPos = transform.position;
			newPos.x -= movementSpeed * Time.deltaTime;
			transform.position = newPos;
			transform.Rotate (0.0f, 0.0f, 6.0f * rotationsPerMinuteTrash * Time.deltaTime);
		}

	}

	public double GetRandomNumber(double minimum, double maximum)
	{ 
		System.Random random = new System.Random();
		return random.NextDouble() * (maximum - minimum) + minimum;
	}
}
