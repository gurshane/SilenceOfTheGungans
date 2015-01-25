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
	public Text killsTxt;
	public int kills;
	private GameObject player;
	public GameObject jjPrime;
	public GameObject spawn1;
	public GameObject spawn2;
	private CamerController cContr;

	// Use this for initialization
	void Start () {

		isPlayerAlive = true;
		health = 100;
		ammo = 200;
		parts = 0;
		kills = 0;
		player = GameObject.FindWithTag ("Player");
		GameObject temp = GameObject.FindWithTag ("MainCamera");
		cContr = temp.GetComponent<CamerController> ();
		audio.Play ();
		//cContr
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

	public void updateKills()
	{

		kills++;
		killsTxt.text = "KILLS: " + kills;

		if(kills%50 == 0)
		{
			cContr.playsMusic ();
			StartCoroutine(Spawns(spawn1));
			StartCoroutine (Spawns (spawn2));

		}


	}

	IEnumerator Spawns(GameObject spawnLocation){

		yield return new WaitForSeconds (1.0f);

		for(int i = 0; i < 25; i++)
		{
			
			Vector3 spawnPosition = new Vector3 (spawnLocation.transform.position.x, spawnLocation.transform.position.y, spawnLocation.transform.position.z);
			Quaternion spawnRotation = Quaternion.identity;
			
			Instantiate ( jjPrime, spawnPosition, spawnRotation);
			
			
		}



	}


	public void updateParts(){

		parts++;

		partsTxt.text = "Parts: " + parts + "/20";
		storyTxt.text = "MISSION LOG \nPART COLLECTED";
		
		if(parts == 20)
		{
			//Display win text
			storyTxt.text = "MISSION LOG: \nYOU ESCAPED";
			leave ();
		}

		StartCoroutine(WipeScreen ());

	}

	public bool updateHealth(int moreHealth){

		if(health == 100)
		{

			return false;
		}

		health = (health + moreHealth);

		if(health > 100){

			health = 100;
		}

		healthTxt.text = "Health: " + health;
		storyTxt.text = "MISSION LOG: \nHEALTH GAINED";
			
		return true;

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
		storyTxt.text = "MISSION LOG: \nAMMO COLLECTED";
		StartCoroutine (WipeScreen ());
		//updateh ammo text and tell user he/she got ammo

	}

	public IEnumerator WipeScreen()
	{

		yield return new WaitForSeconds (7.0f);

		storyTxt.text = "";

	}


	public void killPlayer()
	{

		isPlayerAlive = false;
		GameObject temp = GameObject.FindWithTag ("Player");
		temp.SetActive (false);
		storyTxt.text = "MISSION LOG: \nYOU DIED";
		//pop up YOU ARE DEAD text in GUI
		StartCoroutine(WipeScreen ());
		Application.LoadLevel ("LoseScreen");

	}



	public bool getPlayerStatus()
	{

		return isPlayerAlive;

	}

}
