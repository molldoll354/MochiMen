using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammerswing : MonoBehaviour
{
	public GameObject hammer;
	bool canSwing;
	bool canRaise;
	// Use this for initialization
	void Start ()
	{
		canSwing = false;
		canRaise = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.A)) {
			if (hammer.transform.eulerAngles.z < 31) {
				transform.Rotate (0f, 0f, 100f * Time.deltaTime);
			}
		}
		if (hammer.transform.eulerAngles.z > 30) {
			canSwing = true;
			canRaise = false;
		}
		if (canSwing == true) {
			if (Input.GetKey (KeyCode.S)) {
				transform.Rotate (0f, 0f, -100f * Time.deltaTime);
			}
		} 
	}
	void OnCollisionEnter(Collision other){
		if (other.collider.tag == "mochi") {
			canSwing = false;
			canRaise = true;
			Debug.Log ("HIT");
		}
	}
}
