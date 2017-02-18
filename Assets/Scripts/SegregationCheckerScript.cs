using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class SegregationCheckerScript : MonoBehaviour {

	float timeLeft = 5.0f;
    bool moveToPlace = false;
    int items = 4;
	public Text test;
    GameObject[] objects;
    Sprite[] sprites;
    Sprite[] bioSprites;
    Sprite[] nonBioSprites;
    Ray ray;
    RaycastHit hit;

    // Use this for initialization
    void Start () {
		GameStats.Progress++;
		GameStats.CurrentLevel = 5;
        objects = new GameObject[3];
        objects[0] = GameObject.FindGameObjectWithTag("obj1");
        objects[1] = GameObject.FindGameObjectWithTag("obj2");
        objects[2] = GameObject.FindGameObjectWithTag("obj3");

        sprites = new Sprite[6];
        sprites[0] = Resources.Load<Sprite>("apple");
        sprites[1] = Resources.Load<Sprite>("banana");
        sprites[2] = Resources.Load<Sprite>("bottle");
        sprites[3] = Resources.Load<Sprite>("can");
        sprites[4] = Resources.Load<Sprite>("chips");
        sprites[5] = Resources.Load<Sprite>("plasticbag");

        bioSprites = new Sprite[2];
        bioSprites[0] = Resources.Load<Sprite>("apple");
        bioSprites[1] = Resources.Load<Sprite>("banana");

        nonBioSprites = new Sprite[4];
        nonBioSprites[0] = Resources.Load<Sprite>("bottle");
        nonBioSprites[1] = Resources.Load<Sprite>("can");
        nonBioSprites[2] = Resources.Load<Sprite>("chips");
        nonBioSprites[3] = Resources.Load<Sprite>("plasticbag");
        //test = GameObject.Find("test").GetComponent<Text>();

        System.Random rand = new System.Random();
        int num = rand.Next(0, sprites.Length);
        objects[0].GetComponent<SpriteRenderer>().sprite = sprites[num];

        num = rand.Next(0, sprites.Length);
        objects[1].GetComponent<SpriteRenderer>().sprite = sprites[num];

        num = rand.Next(0, sprites.Length);
        objects[2].GetComponent<SpriteRenderer>().sprite = sprites[num];
    }

 
    /*for extensible in the future HAHAHAHA :((((((((((((((((((*/
    void moveObjects() {
        Vector3 vector = new Vector3((float) -2.48, 0, 0);
        objects[0].transform.Translate(vector);
        System.Random rand = new System.Random();
        int num = rand.Next(0, sprites.Length);
        objects[0].GetComponent<SpriteRenderer>().sprite = sprites[num];
        objects[0].SetActive(false);
        
        GameObject temp = objects[0];
        objects[0] = objects[1];
        if (items > 1)
        {
            objects[1] = objects[2];
            objects[2] = temp;
        }
        moveToPlace = true;
    }

	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		//test.text = "Segregation " + (int) timeLeft;
        /* RIP ME HUHU*/
        if (moveToPlace) {
            Vector3 vector = new Vector3((float)0.40, 0, 0);
            objects[0].transform.Translate(vector);
            if (items > 1)
                objects[1].transform.Translate(vector);
            if (objects[0].transform.position.x == -0.04) {
                moveToPlace = false;
                if (items > 2)
                    objects[2].SetActive(true);
            }
                
            
        }

		//pag di nagawa iyak
		if (timeLeft < 0) {
			GameStats.HasPassed = false;
			SceneManager.LoadScene ("ProgressScreen", LoadSceneMode.Single);
		}

		//pag nagawa niya
		if (items == 0) {
            GameStats.HasPassed = true;
            SceneManager.LoadScene ("ProgressScreen", LoadSceneMode.Single);
		}

        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                // create and save ray from camera touch
                ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

                // create and if collided with something
                if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                {

                    if (hit.collider.tag == "biocan") {
                        Sprite item = objects[0].GetComponent<SpriteRenderer>().sprite;
                        if (checkInSprites(bioSprites, item)) {
                            items--;
                            moveObjects();
                        }
                        else
                            SceneManager.LoadScene("ProgressScreen", LoadSceneMode.Single);
                    }
                        

                    if (hit.collider.tag == "nonbiocan")
                    {
                        Sprite item = objects[0].GetComponent<SpriteRenderer>().sprite;
                        if (checkInSprites(nonBioSprites, item))
                        {
                            items--;
                            moveObjects();
                        }
                        else
                            SceneManager.LoadScene("ProgressScreen", LoadSceneMode.Single);

                    }

                }


            }
        }

    }

    bool checkInSprites(Sprite[] sprites, Sprite sprite) {
        for (int i = 0; i < sprites.Length; i++)
            if (sprite == sprites[i])
                return true;
        return false;
    }
}
