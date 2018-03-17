using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class GameOverManager : MonoBehaviour {

	public CannonInteractionScript whetherEscaped;
	public float restartDelay = 5f;         // Time to wait before restarting the level


	public Animator anim;                          // Reference to the animator component.
	//float restartTimer;                     // Timer to count up to restarting the level


	void Start ()
	{
		// Set up the reference.
		anim = GetComponent <Animator> ();
		//escaped = GameObject.Find("cannon").GetComponent<CannonInteractionScript>();
	}


	void Update ()
	{
		// If the player has run out of health...
		if(whetherEscaped.escaped == true)
		{
			// ... tell the animator the game is over.
			anim.Play ("GameOver");

			// .. increment a timer to count up to restarting.
			//			restartTimer += Time.deltaTime;

			// .. if it reaches the restart delay...
				if(Input.GetKey (KeyCode.R))
						{
							// .. then reload the currently loaded level.
							Application.LoadLevel(Application.loadedLevel);
						}
		}
	}




}
