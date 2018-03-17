using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pageSound : MonoBehaviour {



	void OnTriggerEnter(Collider collider) {
		if(collider.gameObject.tag.Equals("Player")) {
			//Debug.Log ("Playing Page Sound");
			//gameObject.GetComponent<AudioSource>().PlayOneShot(sound);
			gameObject.GetComponent<AudioSource>().Play();
		}
	}
}
