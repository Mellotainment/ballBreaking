using UnityEngine;
using System.Collections;

public class BallClones : MonoBehaviour {


	void OnCollisionEnter( Collision col)
	{
		

		if(col.gameObject.name == "Ball")
		{
			Destroy(col.gameObject);
		}
		}
}