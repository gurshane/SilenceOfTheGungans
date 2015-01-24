using UnityEngine;
using System.Collections;

public class GameLoop : MonoBehaviour {

	private bool isPlayerAlive;


	// Use this for initialization
	void Start () {

		isPlayerAlive = true;
	
	}

	public void killPlayer()
	{

		isPlayerAlive = false;


	}

	public bool getPlayerStatus()
	{

		return isPlayerAlive;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
