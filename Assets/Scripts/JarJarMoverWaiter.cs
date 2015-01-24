using UnityEngine;
using System.Collections;

public class JarJarMoverWaiter : MonoBehaviour {

	public Transform player;

	public float speed;

	private bool isSeen;


	void Start()
	{

		isSeen = false;

	}

	void FixedUpdate(){

		if(isSeen)
		{
			rigidbody.transform.position = Vector3.MoveTowards (rigidbody.transform.position, player.position, speed * Time.deltaTime);

		}
	}

	public void gotSeen(){

		isSeen = true;

	}
	


}
