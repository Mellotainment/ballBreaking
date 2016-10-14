using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {


	public GameObject Ball;
	public int scoreValue;
	public movement ball;

	// Use this for initialization
	void Start () {
		movement.AddScore (scoreValue);
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//movement
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			transform.position += new Vector3 (0, 0, 1);
		}

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			transform.position += new Vector3 (0, 0, -1);
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			transform.position += new Vector3 (-1, 0, 0);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			transform.position += new Vector3 (1, 0, 0);
		}

		//Destroy

		//void OnCollisionEnter( Collision
			
		//	if(col.gameObject.tag == "Ball")
			{
		//		Destroy(col.gameObject);
	
	}
	 
	}
}

