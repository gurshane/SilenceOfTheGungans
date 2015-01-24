using UnityEngine;
using System.Collections;

public class CollectAmmo : MonoBehaviour {


	private GameLoop gLoop;

	void Start(){

		GameObject gController = GameObject.FindWithTag ("GameController");
		gLoop = gController.GetComponent <GameLoop> ();

	}

	void OnTriggerEnter(Collider other){

		if (other.tag == "Player") {

			gLoop.updateAmmo(25);
			Destroy (gameObject);

		}


	}
}
