using UnityEngine;
using System.Collections;

public class HealthPickup : MonoBehaviour {

	private GameLoop gLoop;

	// Use this for initialization
	void Start () {
	
		GameObject temp = GameObject.FindWithTag ("GameController");
		gLoop = temp.GetComponent <GameLoop> ();

	}
	
	void OnTriggerEnter(Collider other)
	{

		if(other.tag == "Player")
		{
			if(gLoop.updateHealth (25)){
				Destroy(gameObject);
				StartCoroutine(gLoop.WipeScreen ());
			}
		}

	}
}
