using UnityEngine;
using System.Collections;

public class JarJarAlarmSound : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{

		if(other.tag == "Player")
		{
			audio.Play ();
		}

	}



}
