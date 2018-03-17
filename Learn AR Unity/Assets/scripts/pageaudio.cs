using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class pageaudio : MonoBehaviour {
	public float bpm = 140.0F;
	public int numBeatsPerSegment = 16;
	public AudioClip[] clips = new AudioClip[2];
	private double nextEventTime;
	private int flip = 0;
	private AudioSource[] audioSources = new AudioSource[2];
	private bool running = false;
	void Start() {
		int i = 0;
		while (i < 2) {
			GameObject child = new GameObject("Player");
			child.transform.parent = gameObject.transform;
			audioSources[i] = child.AddComponent<AudioSource>();
			i++;
		}
		nextEventTime = AudioSettings.dspTime + 2.0F;
		running = true;
	}
	void Update() {
		if (!running)
			return;

		double time = AudioSettings.dspTime;
		if (time + 1.0F > nextEventTime) {
			audioSources[flip].clip = clips[flip];
			audioSources[flip].PlayScheduled(nextEventTime);
			Debug.Log("Scheduled source " + flip + " to start at time " + nextEventTime);
			nextEventTime += 60.0F / bpm * numBeatsPerSegment;
			flip = 1 - flip;
		}
	}
}