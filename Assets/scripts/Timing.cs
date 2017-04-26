using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timing : MonoBehaviour {

	//public float hammerHitTime;
	//public float handHitTime;
	//public float maxTimeDifference;
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

	void OnTriggerExit2D(Collider2D other){
		//Debug.Log ("HIT");
		if (other.gameObject.CompareTag ("hand")){
			handHit = true;
		}
		if (other.gameObject.CompareTag ("hammer")){
			if(handHit==true){
				if (timer > 0) {
					score++;
					handHit = false;
					timer = 5;
				}
			}
		}
	}
}
