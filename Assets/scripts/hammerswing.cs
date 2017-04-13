using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammerswing : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)) {
			transform.Rotate (0f, 0f, -100f * Time.deltaTime);
		}
	}
}
