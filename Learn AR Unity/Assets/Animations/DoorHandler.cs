using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Created by Alexandre Geubelle 10/3/2017
 */
public class DoorHandler : MonoBehaviour {

	//Creation of animation of door and basis for this code comes from:
	//https://www.youtube.com/watch?v=jKe2zMFa2mw

	private Animator _animator = null;

	void Start () {
		_animator = GetComponentInChildren<Animator> ();
	}

	void Update () {
		
	}

	void OnTriggerEnter(Collider collider) {
		BoxCollider[] colliders = collider.gameObject.GetComponents<BoxCollider> ();
		foreach(BoxCollider current in colliders ) {
			if (current.isTrigger && current.enabled) {
				_animator.SetBool ("isopen", true);
				Debug.Log ("Enter");
			}
		}
	}

	void OnTriggerExit(Collider collider) {
		BoxCollider[] colliders = collider.gameObject.GetComponents<BoxCollider> ();
		foreach(BoxCollider current in colliders ) {
			if (current.isTrigger && current.enabled) {
				_animator.SetBool ("isopen", false);
				Debug.Log ("Leave");
			}
		}
	}
}
