using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammerswing : MonoBehaviour
{
	Transform hammer;
	public float rotateSpeed;
	public float maxAngleBack;
	public float maxAngleForward;
	bool canSwing;
	bool canRaise = true;

	void Start ()
	{
		hammer = this.GetComponent<Transform> ();
		canSwing = false;
		canRaise = true;
	}
	
	void FixedUpdate ()
	{
		if (canRaise == true) {
			if (Input.GetKey (KeyCode.A)) {
				Debug.Log ("should raise");
				if (hammer.eulerAngles.z < maxAngleBack + 1f || hammer.eulerAngles.z > maxAngleForward) {
					transform.Rotate (0f, 0f, rotateSpeed * Time.deltaTime);
					canSwing = true;
				}
			}
		}

		if (canSwing == true) {
			if (Input.GetKey (KeyCode.S)) {
				hammer.Rotate (0f, 0f, -1 * rotateSpeed * Time.deltaTime);
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
