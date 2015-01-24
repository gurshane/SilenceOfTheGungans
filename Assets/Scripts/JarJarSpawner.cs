using UnityEngine;
using System.Collections;

public class JarJarSpawner : MonoBehaviour {

	public int numJJs;
	private GameObject jjPrime;

	// Use this for initialization
	void Start () {
	
		jjPrime = GameObject.FindWithTag ("JarJar");
			
		StartCoroutine (Spawns ());

	}


	IEnumerator Spawns()
	{


		yield return new WaitForSeconds (5.0f);
		for(int i = 0; i < numJJs; i++)
		{

			Vector3 spawnPosition = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
			Quaternion spawnRotation = Quaternion.identity;

			Instantiate ( jjPrime, spawnPosition, spawnRotation);


		}

		yield return new WaitForSeconds(5.0f);

	}
		
		
	// Update is called once per frame
	void ReSpawn () {


		StartCoroutine (Spawns ());

	}
}
