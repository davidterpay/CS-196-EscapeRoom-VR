using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CannonInteractionScript : MonoBehaviour {

	[SerializeField]
	Text gameText;

	private GameObject gunPowder;
	private bool hasGunPowder;

	public bool escaped = false;

	// Use this for initialization
	void Start () {
		gunPowder = null;
		hasGunPowder = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (gunPowder != null) {
			if (Input.GetKey (KeyCode.Space)) {
				gameText.text = "Gun powder loaded.";
				hasGunPowder = true;
				GameObject.Destroy (gunPowder);
			}
		}
	}

	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.tag.Equals ("GunPowder")) {
			gunPowder = collider.gameObject;
			gameText.text = "Press space to load gunpowder.";
			escaped = true;
		}
	}

	void OnTriggerExit(Collider collider) {
		if (collider.gameObject.tag.Equals ("GunPowder")) {
			gunPowder = null;
			gameText.text = "";
		}
	}
}
