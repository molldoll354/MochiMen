using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timing : MonoBehaviour {

	//public float hammerHitTime;
	//public float handHitTime;
	//public float maxTimeDifference;
	public bool hammerLeave;
	public bool handLeave;
	public static float score;
	float timer;


	void Start () {
		timer = 5;
		handLeave = false;
		GetComponent<Animator> ().SetBool ("handHit", false);
		GetComponent<Animator> ().SetBool ("hammerHit", false);
	}
	
	void Update () {
		Debug.Log(" Score: " + score + " Time: "+ timer);
		if (handLeave == true) {
			timer -= Time.deltaTime;
			}
		}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("hand")){
			GetComponent<Animator> ().SetBool ("handHit", true);
		}
		if (other.gameObject.CompareTag ("hammer")) {
			GetComponent<Animator> ().SetBool ("hammerHit", true);
		}
	}
	void OnTriggerExit2D(Collider2D other){
		//Debug.Log ("HIT");
		if (other.gameObject.CompareTag ("hand")){
			handLeave = true;
			GetComponent<Animator> ().SetBool ("handHit", false);
		}
		if (other.gameObject.CompareTag ("hammer")){
			GetComponent<Animator> ().SetBool ("hammerHit", false);
			if(handLeave==true){
				if (timer > 0) {
					score++;
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