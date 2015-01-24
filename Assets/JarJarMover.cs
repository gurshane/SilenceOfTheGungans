using UnityEngine;
using System.Collections;

public class JarJarMover : MonoBehaviour {

	private GameLoop gameLoop;
	private bool playerStatus;
	public Transform player;

	public float speed;
	public int count;

	// Use this for initialization
	void Start () {
	
		GameObject tempObj = GameObject.FindWithTag ("GameController");


		if(tempObj == null)
		{
			Debug.Log ("Issue!");
		}else{

			gameLoop = tempObj.GetComponent <GameLoop> ();
			playerStatus = gameLoop.getPlayerStatus ();
			
		}

		count = 0;

	}


	void FixedUpdate(){

		rigidbody.transform.position = Vector3.MoveTowards (rigidbody.transform.position, player.position, speed * Time.deltaTime);

	}


}
