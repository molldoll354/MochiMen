using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeImage : MonoBehaviour {

	public float fadeSpeed;
	Image myImage;
	bool isFading;

	void Start () {
		myImage = GetComponent<Image> ();
	}

	void Update () {
		if (Input.GetKey(KeyCode.F) && myImage.color.a < 1f){
			myImage.color = new Color (myImage.color.r, myImage.color.g, myImage.color.b, myImage.color.a + fadeSpeed * Time.deltaTime);
		}
	}
}
