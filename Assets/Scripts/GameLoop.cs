using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLoop : MonoBehaviour {

	private bool isPlayerAlive;
	public int health;
	public int ammo;
	private int parts;
	public Text healthTxt;
	public Text ammoTxt;
	public Text storyTxt;
	public Text partsTxt;
	private GameObject player;

	// Use this for initialization
	void Start () {

		isPlayerAlive = true;
		health = 100;
		ammo = 100;
		parts = 0;
		player = GameObject.FindWithTag ("Player");

		//tellAStory();
	
	}
	//
	public void updateHealth(){
		health = health - 10;
		healthTxt.text = "Health: " + health;

		if(health == 0){
			killPlayer ();
		}
	}

	public void updateParts(){

		parts++;

		partsTxt.text = "Parts: " + parts + "/20";
		storyTxt.text = "PART COLLECTED";
		
		if(parts == 20)
		{
			//Display win text
			storyTxt.text = "YOU ESCAPED";
			leave ();
		}

		StartCoroutine(WipeScreen ());

	}

	public void updateHealth(int moreHealth){

		if((health + moreHealth) > 100)
		{

			return;
		}

		health = health + moreHealth;
		healthTxt.text = "Health: " + health;

	}


	void leave(){

		Application.LoadLevel ("LoseScreen 1");

	}

	public void updateAmmo(){
		ammo--;
		ammoTxt.text = "Ammo: " + ammo;
		//update ammo text
	}

	public void updateAmmo(int moreAmmo){

		ammo = ammo + moreAmmo;
		ammoTxt.text = "Ammo: " + ammo;
		//updateh ammo text and tell user he/she got ammo

	}

	public IEnumerator WipeScreen()
	{

		yield return new WaitForSeconds (5.0f);

		storyTxt.text = "";

		yield return new WaitForSeconds(5.0f);

	}


	public void killPlayer()
	{

		isPlayerAlive = false;
		GameObject temp = GameObject.FindWithTag ("Player");
		temp.SetActive (false);
		storyTxt.text = "YOU DIED";
		//pop up YOU ARE DEAD text in GUI
		StartCoroutine(WipeScreen ());
		Application.LoadLevel ("LoseScreen");

	}



	public bool getPlayerStatus()
	{

		return isPlayerAlive;

	}

}
