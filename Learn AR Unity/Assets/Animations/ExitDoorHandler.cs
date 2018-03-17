using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * Created by Alexandre Geubelle 10/3/2017
 */
public class ExitDoorHandler : MonoBehaviour {

	//Creation of animation of door and basis for this code comes from:
	//https://www.youtube.com/watch?v=jKe2zMFa2mw

	private Animator _animator = null;

	private bool doorOpen;

	[SerializeField]
	Text text;

	void Start () {
		_animator = GetComponentInChildren<Animator> ();
		doorOpen = false;
	}

	void Update () {

	}

	void OnTriggerEnter(Collider collider) {

		if (doorOpen) {
			BoxCollider[] colliders = collider.gameObject.GetComponents<BoxCollider> ();
			foreach(BoxCollider current in colliders ) {
				if (current.isTrigger && current.enabled) {
					_animator.SetBool ("isopen", true);
				}
			}
			return;
		}

		/*
		 * Do nothing.
		 */
		if (text != null) {
			text.text = "Door is locked";
		}
	}

	void OnTriggerExit(Collider collider) {
		/*
		 * Do nothing.
		 */
		if (text != null) {
			text.text = "Be explosive.";
		}
	}
}
