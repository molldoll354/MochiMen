using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MochiZone : MonoBehaviour {

	public GameObject mochi;
	public GameObject hammer;
	public GameObject hand;
	public static int score;
	public static int fails;
	//public Text finishText;
	// Use this for initialization
	void Start () {
		score = 0;
		fails = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Score: " + score + " Fails: " + fails);

		if (score == 10) {
			//finishText.text = "You Win!";
		}
		if (fails == 3) {
			//finishText.text = "You Lose!";
		}
	}
}