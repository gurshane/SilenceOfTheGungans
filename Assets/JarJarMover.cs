using UnityEngine;
using System.Collections;

public class JarJarMover : MonoBehaviour {

	private GameLoop gameLoop;
	private bool playerStatus;
	public Transform player;

	public float speed;

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

		StartCoroutine(Stalk ());

	}
	
	IEnumerator Stalk()
	{


		while(playerStatus)
		{

			//transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

			Debug.Log ("started");

			//playerStatus = gameLoop.getPlayerStatus ();

			playerStatus = false;

			if(!playerStatus)
			{
				yield return new WaitForSeconds(0.01f);
				return false;
			}

		}

	}

}
