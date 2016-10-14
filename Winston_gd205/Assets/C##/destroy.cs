using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {

	public GameObject Ballsprefab;
	GameObject BallsPrefabClone;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



			

		{
			if (Input.GetKeyDown("e")){
				BallsPrefabClone = Instantiate(Ballsprefab, transform.position, Quaternion.identity) as GameObject;
				Destroy(BallsPrefabClone,3);

			{
				


		}
	}
}
	}
}
	