using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speedPlayer;
	public float fireRate;
	public float speed;
	public GameObject shot;
	public Transform shotSpawn;
	public GameObject Explosion;
	public AudioClip aud1;
	public AudioClip aud2;
	public float turnSpeed;
	private GameLoop gLoop;
	public GameObject spawnLocation;

	private float nextFire;
	
	void Start()
	{
		GameObject tempCont = GameObject.FindWithTag ("GameController");
		gLoop = tempCont.GetComponent <GameLoop> ();

		nextFire = 0.25f;
		
	}


	void FixedUpdate()
	{

		float moveHor = Input.GetAxis ("Horizontal");
		float moveVer = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHor, 0.0f, moveVer);

		//if(moveHor == 0 && moveVer == 0)
		//{

			//audio.Stop ();

		//}

		//audio.Play ();
		rigidbody.velocity = (movement * speedPlayer);




	}

	void Update()
	{
		if(Input.GetButton ("Fire1") && Time.time > nextFire)
		{
			if(gLoop.ammo == 0){
				return;
			}
			gLoop.updateAmmo ();
			audio.PlayOneShot (aud2);
			//GameObject tempEx = Instantiate (Explosion, shotSpawn.position, shotSpawn.rotation) as GameObject;
			nextFire = fireRate + Time.time;
			GameObject shotFired = Instantiate (shot, shotSpawn.position, shotSpawn.rotation) as GameObject;
			Destroy (shotFired, 5.0f);
			//Destroy (tempEx,2.0f);

			
		}
		
	}

}