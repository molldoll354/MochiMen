using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MochiZone : MonoBehaviour {

	//public GameObject mochi;
	//public GameObject hammer;
	//public GameObject hand;
	public static int score;
	public static int fails;
	public Image mochiZoneImage;
	public float mochiZoneImageFadeSpeed;
	public AudioClip mochiZoneSound;
	public Text finishText;

	void Start () {
		score = 0;
		fails = 0;
	}
	
	void Update () {
		if (score == 10) {
			// now in mochi zone
			Camera.main.gameObject.GetComponent<AudioSource>().clip = mochiZoneSound;
			Camera.main.gameObject.GetComponent<AudioSource> ().Play ();
			StartCoroutine ("fadeImageIn");
		}
		if (score == 20){
			finishText.gameObject.SetActive (true);
			Time.timeScale = 0;
		}

		/*
		if (fails == 3) {
		}
		*/
	}

	IEnumerator fadeImageIn(){
		while(mochiZoneImage.color.a < 1f){
			mochiZoneImage.color = new Color (mochiZoneImage.color.r, mochiZoneImage.color.g, mochiZoneImage.color.b, mochiZoneImage.color.a + mochiZoneImageFadeSpeed * Time.deltaTime);
			yield return new WaitForFixedUpdate();
		}

	}

}