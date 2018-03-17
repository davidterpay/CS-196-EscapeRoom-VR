using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyScript : MonoBehaviour {

	[SerializeField]
	GameObject noteObject;

	[SerializeField]
	Text noteText;

	private string lloydNoteString = "<i>Notification</i>: <color=#000000EA>You just got a letter from your loyal CabinBoy, Lloyd." +
		"\n\nDear Captain:" +
		"\n\tI am sorry that I could not save you when the mutiny happened. I left this letter along with the key to offer you some help." +
		"This is the key to the lock of the jail cell. In addition, here are the steps to build a cannon." +
		"\n\t\t1. You need a cannon ball." +
		"\n\t\t2. You need gunpowder." +
		"\n\nBest regards." +
		"\nLloyd</color>";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter( Collider collider ) {
		if (collider.tag.Equals("Player")) {
			BoxCollider[] colliders = collider.gameObject.GetComponents<BoxCollider> ();
			foreach (BoxCollider current in colliders) {
				if (current.isTrigger && current.enabled) {
					noteText.text = lloydNoteString;
					noteObject.SetActive (true);
				}
			}
		}
	}

	void OnTriggerExit( Collider collider ) {
		if (collider.tag.Equals("Player")) {
			BoxCollider[] colliders = collider.gameObject.GetComponents<BoxCollider> ();
			foreach (BoxCollider current in colliders) {
				if (current.isTrigger && current.enabled) {
					noteObject.SetActive (false); 
				}
			}
		}
	}

}
