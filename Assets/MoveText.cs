using UnityEngine;
using System.Collections;

public class MoveText : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Update () {
	
		transform.position = new Vector3 (transform.position.x, transform.position.y + speed, transform.position.z);

		if(Input.GetKeyDown (KeyCode.R))
		{

			Application.LoadLevel ("MainScene");

		}


	}




}
