using UnityEngine;
using System.Collections;

public class JarJarAlarmSoundAndWaiters : MonoBehaviour {


	public int speed;


	void OnTriggerEnter(Collider other)
	{

		if(other.tag == "JarJarWaits")
		{
			audio.Play ();
			//StartCoroutine (gotSeen (other.rigidbody));

		}

	}

	IEnumerator gotSeen(Rigidbody other)
	{
		while(true){
			other.transform.position = Vector3.MoveTowards (other.transform.position, gameObject.transform.position, speed * Time.deltaTime);
		}
		
	}



}