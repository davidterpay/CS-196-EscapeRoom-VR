using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorAudio : MonoBehaviour {

	void OnTriggerEnter(Collider collider) {
		if(collider.gameObject.tag.Equals("Player")) {
			//Debug.Log ("Playing Sound");
			//gameObject.GetComponent<AudioSource>().PlayOneShot(sound);
			gameObject.GetComponent<AudioSource>().Play();
		}
	}
}
