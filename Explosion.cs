using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

	public Transform explosion;

	// Use this for initialization
	void Start () {
		explosion.GetComponent<ParticleSystem> ().enableEmission = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag.Equals ("GunPowder")) 
		{
			explosion.GetComponent<ParticleSystem> ().enableEmission = true;
			StartCoroutine (stopExplosion ());
		}
	}

	IEnumerator stopExplosion()
	{
		yield return new WaitForSeconds (.4f);
		explosion.GetComponent<ParticleSystem> ().enableEmission = false;
	}
}
