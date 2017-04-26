using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timing : MonoBehaviour {

	public AudioClip[] hammerHits;
	public AudioClip[] handHits;
	public bool hammerHit;
	public bool handHit;
	public static float score;
	float timer;

	void Start () {
		timer = 5;
		handHit = false;
	}
	
	void Update () {
		//Debug.Log("" + handHit + " Score: " + score + " Time: "+ timer);
		if (handHit == true) {
			timer -= Time.deltaTime;
			}
		}
		
	void OnTriggerEnter2D(Collider2D other){
		Debug.Log("Score: " + score);
		if (other.gameObject.CompareTag ("hand")){
			Sound.me.PlaySound (ChooseRandomSound (handHits), 1f);
			handHit = true;
		}
		if (other.gameObject.CompareTag ("hammer")){
			Sound.me.PlaySound (ChooseRandomSound (hammerHits), 1f);
			if(handHit==true){
				if (timer > 0) {
					score++;
					handHit = false;
					timer = 5;
				}
			}
		}
	}

	AudioClip ChooseRandomSound(AudioClip[] sounds){
		int numSounds = sounds.Length;
		return sounds [Random.Range (0, numSounds - 1)];
	}
}