using UnityEngine;
using System.Collections;

public class CollectPart : MonoBehaviour {

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
			gLoop.updateParts ();
			Destroy (gameObject);
	
		}
	}
}
