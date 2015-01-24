using UnityEngine;
using System.Collections;

public class Blurb : MonoBehaviour {

	private GameLoop gLoop;

	// Use this for initialization
	void Start () {
	
		GameObject temp = GameObject.FindWithTag ("GameController");
		gLoop = temp.GetComponent <GameLoop> ();

	}
	
	void OnTriggerEnter(Collider other){


		if(other.tag == "Player")
		{
			if(gameObject.name == "DeadTrooper1")
			{
				gLoop.storyTxt.text = "MISSION LOG:\nHERE LIES MARC.\nSPELLED WITH A 'C', WEIRD";
				StartCoroutine (gLoop.WipeScreen());
			}

			if(gameObject.name == "DeadTrooper2")
			{
				gLoop.storyTxt.text = "MISSION LOG:\nHERE LIES THE MONSTER KING\nLOOKS MORE LIKE SLEEPING BEAUTY TO ME";
				StartCoroutine (gLoop.WipeScreen());
			}

			if(gameObject.name == "MahTent")
			{
				gLoop.storyTxt.text = "MISSION LOG:\nTHIS IS OUR TENT\nTASTES LIKE CHICKEN";

				if(gLoop.health < 100) {

					gLoop.updateHealth (100-gLoop.health);

				}

				Destroy (gameObject);
				StartCoroutine (gLoop.WipeScreen());
			}

			if(gameObject.name == "MissingGuyTent")
			{
				gLoop.storyTxt.text = "MISSION LOG:\nTHIS GUY IS NEVER HERE\nKIND OF LIKE OUR DAD, ZING =(";
				StartCoroutine (gLoop.WipeScreen());
			}

			if(gameObject.name == "MessageTrigger")
			{
				gLoop.storyTxt.text = "MISSION LOG:\nFOUND THE DEAD GUY\nSTILL OWES ME FIVE BUCKS";
				gLoop.updateAmmo (100);
				StartCoroutine(gLoop.WipeScreen());
				Destroy (gameObject);
			}

			if(gameObject.name == "FireBall")
			{
				gLoop.storyTxt.text = "MISSION LOG:\nFIRE\nHOT";
				StartCoroutine(gLoop.WipeScreen());
			}

			if(gameObject.name == "Spacething")
			{
				gLoop.storyTxt.text = "MISSION LOG:\nIT JUST NEEDS A LITTLE TLC";
				StartCoroutine(gLoop.WipeScreen());
			}

			if(gameObject.name == "WorldWarning")
			{
				gLoop.storyTxt.text = "MISSION LOG:\nCOLLECT 20 SPACESHIP\nPARTS TO LEAVE THIS ROCK";
				StartCoroutine(gLoop.WipeScreen());
			}

		}


	}
}
