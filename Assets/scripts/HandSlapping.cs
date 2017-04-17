using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandSlapping : MonoBehaviour {
	public Transform[] pathPoints;
	public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)){
			StartCoroutine("FollowPath");
		}
	}

	IEnumerator FollowPath(){
		int currentPathIndex = 0;
		while (true) {
			Transform target = pathPoints [currentPathIndex];
			while (transform.position != target.position) {
				transform.position = Vector3.MoveTowards (transform.position, target.position, moveSpeed * Time.fixedDeltaTime);
				yield return new WaitForSeconds (.01f);
			}
			if (currentPathIndex < pathPoints.Length - 1) {
				currentPathIndex++;
			} else {
				currentPathIndex = 0;
			}
			yield return new WaitForSeconds (0f);
		}
	}

}
