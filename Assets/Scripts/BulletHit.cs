using UnityEngine;
using System.Collections;


public class BulletHit : MonoBehaviour {

	public GameObject Explosion;

	void OnTriggerEnter(Collider other)
	{

		if(other.tag == "Boundary")
		{
			return;
		}

		GameObject tempExp = Instantiate(Explosion, rigidbody.position, rigidbody.rotation) as GameObject;

		
		if(other.tag == "JarJar")
		{
			//give points
			Destroy (other.gameObject);
			Destroy (tempExp.gameObject, 3.0f);
			gameObject.SetActive (false);
			return;
			
		}

		gameObject.SetActive (false);
		Destroy (tempExp.gameObject, 3.0f);

	}
}
