using UnityEngine;
using System.Collections;

public class MoveBall : MonoBehaviour {

	public float speed;

	void FixedUpdate()
	{

		float moveHor = Input.GetAxis ("Horizontal");
		float moveVer = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHor, 0.0f, moveVer);

		rigidbody.AddForce (movement * speed * Time.deltaTime);

	}

}
