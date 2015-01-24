using UnityEngine;
using System.Collections;

public class JarJarMover : MonoBehaviour {

	public Transform player;

	public float speed;

	void FixedUpdate(){

		rigidbody.transform.position = Vector3.MoveTowards (rigidbody.transform.position, player.position, speed * Time.deltaTime);

	}

	


}
