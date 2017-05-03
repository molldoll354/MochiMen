using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MochiZone : MonoBehaviour {

	//public GameObject mochi;
	//public GameObject hammer;
	//public GameObject hand;
	public static int score;
	public static int fails;
	public Image mochiZoneImage;
	public Image mochiZoneImage2;
	public Image mochiZoneImage3;
	public Image finalImage;
	public float imageFadeSpeed;
	public AudioClip mochiZoneSound;
	public Text finishText;
	public bool hasStartedMochiZone;

	void Start () {
		score = 0;
		fails = 0;
	}
	
	void Update () {
		//scoreText.text = "SCORE: " + score;

		if (score == 10) {
			if (!hasStartedMochiZone) {
				Camera.main.gameObject.GetComponent<AudioSource> ().clip = mochiZoneSound;
				Camera.main.gameObject.GetComponent<AudioSource> ().Play ();
				hasStartedMochiZone = true;
			}
			StartCoroutine (fadeImageIn(mochiZoneImage));
		}
		if (score == 20){
			StartCoroutine (fadeImageIn(mochiZoneImage2));
		}
		if (score == 30){
			StartCoroutine (fadeImageIn(mochiZoneImage3));
		}
		if (score == 40){
			StartCoroutine (FadeScreenOut ());
			SceneManager.LoadScene ("victory scene");
		}

		/*
		if (fails == 3) {
		}
		*/
	}

	IEnumerator FadeScreenOut(){
		while (true){
			finalImage.color = new Color (0, 0, 0, finalImage.color.a + imageFadeSpeed * Time.unscaledDeltaTime);
			if (finalImage.color.a >= 1f) {
			//	myCoolVariable.allowSceneActivation = true;
				SceneManager.LoadScene("victory scene");
			}
			yield return null;
		}
	}

	IEnumerator fadeImageIn(Image fadeThisImage){
		while(fadeThisImage.color.a < 1f){
			fadeThisImage.color = new Color (fadeThisImage.color.r, fadeThisImage.color.g, fadeThisImage.color.b, fadeThisImage.color.a + imageFadeSpeed * Time.deltaTime);
			yield return new WaitForFixedUpdate();
		}
	}

	IEnumerator fadeImageIn(SpriteRenderer fadeThisImage){
		while(fadeThisImage.color.a < 1f){
			fadeThisImage.color = new Color (fadeThisImage.color.r, fadeThisImage.color.g, fadeThisImage.color.b, fadeThisImage.color.a + imageFadeSpeed * Time.deltaTime);
			yield return new WaitForFixedUpdate();
		}
	}

}