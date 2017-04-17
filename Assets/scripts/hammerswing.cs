using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammerswing : MonoBehaviour
{
	public GameObject hammer;
	bool canSwing;
	bool canRaise = true;

	// Use this for initialization
	void Start ()
	{
		canSwing = false;
		canRaise = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Debug.Log ("" + canRaise + " " + canSwing);
		if (canRaise == true) {
			if (Input.GetKey (KeyCode.A)) {
				if (hammer.transform.eulerAngles.z < 31 || hammer.transform.eulerAngles.z > 200) {
					transform.Rotate (0f, 0f, 400f * Time.deltaTime);
					canSwing = true;
				}
			}
		}
		//if (hammer.transform.eulerAngles.z > 30) {
			//canSwing = true;
			//canRaise = false;
		//}
		if (canSwing == true) {
			if (Input.GetKey (KeyCode.S)) {
				transform.Rotate (0f, 0f, -400f * Time.deltaTime);
				canRaise = false;
			}
		} 
	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.CompareTag ("mochi")) {
			Debug.Log ("HIT");
			canSwing = false;
			canRaise = true;
		}
	}
}
