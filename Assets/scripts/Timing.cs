using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timing : MonoBehaviour {

	public float hammerHitTime;
	public float handHitTime;
	public float maxTimeDifference;
	public bool hammerHit;
	public bool handHit;
	public float score;
	float timer;

	void Start () {
		timer = 1000;
	}
	
	void Update () {
		Debug.Log("Score: " + score + " Time: "+ timer);
		if (handHit == true) {
			timer -= Time.deltaTime;
			}
		}

	void OnCollisionEnter2D(Collision2D other){
		Debug.Log ("HIT");
		if (other.gameObject.tag == "hand"){
			//handHitTime = Time.time;
			//CheckTiming ();
			//Debug.Log 
			handHit = true;
		}
		if (other.gameObject.tag == "hammer"){
			//hammerHitTime = Time.time;
			//CheckTiming ();
			//Debug.Log ("Score: " + score);
			if(timer > 0){
				score++;
				handHit = false;
				timer = 1000;
			}
		}
	}

//	void CheckTiming(){
	//	if (Mathf.Abs(handHitTime - hammerHitTime) <= maxTimeDifference){
		//	score++;
	//	}
	//}

}
