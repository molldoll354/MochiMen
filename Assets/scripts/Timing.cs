using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timing : MonoBehaviour {

	//public float hammerHitTime;
	//public float handHitTime;
	//public float maxTimeDifference;
	public Text scoreText;
	bool hammerLeave;
	bool handLeave;
	float timer;
	public AudioClip[] hammerHitSounds;
	public AudioClip[] handHitSounds;
	Sound mySound;

	void Awake(){
		mySound = Sound.me;
	}

	void Start () {
		timer = 5;
		scoreText.text = "SCORE: 0";
		handLeave = false;
		GetComponent<Animator> ().SetBool ("handHit", false);
		GetComponent<Animator> ().SetBool ("hammerHit", false);
	}
	
	void Update () {
		if (handLeave == true) {
			timer -= Time.deltaTime;
			}
		}
		
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("hand")){
			GetComponent<Animator> ().SetBool ("handHit", true);
			mySound.PlaySound (ChooseRandomSound(handHitSounds), 1f);
		}
		if (other.gameObject.CompareTag ("hammer")) {
			GetComponent<Animator> ().SetBool ("hammerHit", true);
			mySound.PlaySound (ChooseRandomSound(hammerHitSounds), 1f);
		}
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.CompareTag ("hand")){
			handLeave = true;
			GetComponent<Animator> ().SetBool ("handHit", false);
		}
		if (other.gameObject.CompareTag ("hammer")){
			GetComponent<Animator> ().SetBool ("hammerHit", false);
			if(handLeave==true){
				if (timer > 0) {
					MochiZone.score++;
					scoreText.text = "SCORE: " + MochiZone.score;
					handLeave = false;
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