using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mochi : MonoBehaviour {

	public Animator mochiAnimatior;

	// Use this for initialization
	void Start () {
		mochiAnimatior = GetComponent<Animator> ();
		//mochiAnimatior.Play ("handSlap");
		Invoke ("PlayAnimation", 2f);
		
	}
	
	// Update is called once per frame
	void Update () {
		//mochiAnimatior.Play ("handSlap");
	}

	void PlayAnimation(){
		mochiAnimatior.Play ("handSlap");
		Debug.Log ("played");
	}

	void OnCollisionEnter2D(Collision2D other){
		//mochiAnimatior.Play ("handSlap");
		Debug.Log ("should play");
	}
}
