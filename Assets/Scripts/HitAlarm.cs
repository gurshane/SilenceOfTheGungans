using UnityEngine;
using System.Collections;

public class HitAlarm : MonoBehaviour {

	private GameLoop gLoop;

	void Start()
	{

		GameObject gObject = GameObject.FindWithTag ("GameController");
		gLoop = gObject.GetComponent <GameLoop> ();

	}

	void OnTriggerEnter(Collider other)
	{

		if(other.tag == "Player" && gameObject.name == "HitAlarm")
		{
			//Debug.Log ("HIT");
			gLoop.updateHealth();

		}

	}
	
}
