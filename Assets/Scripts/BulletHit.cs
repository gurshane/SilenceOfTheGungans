using UnityEngine;
using System.Collections;


public class BulletHit : MonoBehaviour {

	public GameObject Explosion;

	private GameLoop gLoop;
	
	// Use this for initialization
	void Start () {
		
		GameObject temp = GameObject.FindWithTag ("GameController");
		gLoop = temp.GetComponent <GameLoop> ();
		
	}



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
			gLoop.updateKills();
			return;
			
		}

		gameObject.SetActive (false);
		Destroy (tempExp.gameObject, 3.0f);

	}
}
