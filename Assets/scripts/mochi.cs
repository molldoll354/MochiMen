using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mochi : MonoBehaviour {

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
	}

	void OnCollisionEnter2D(Collision2D other){
		//mochiAnimatior.Play ("handSlap");
	}
}
