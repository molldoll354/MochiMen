using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.ImageEffects;


public class buttonscript : MonoBehaviour {

	public Button playButton;
	public Button aboutButton;
	public Button controlsButton;
	public Button quitButton;
	public Button closeAbout;

	public GameObject controlScreen;
	public GameObject aboutScreen;
	public GameObject mainCamera;
	public GameObject playButt;
	public GameObject aboutButt;
	public GameObject controlButt;
	public GameObject quitButt;

	public void PlayScene(){
		SceneManager.LoadScene ("dialogueTest (copy)");
	}
	public void OpenInstructions(){
		Camera.main.GetComponent<Blur> ().enabled = true;
		controlScreen.SetActive (true);

		playButt.SetActive (false);
		aboutButt.SetActive (false);
		controlButt.SetActive (false);
		quitButt.SetActive (false);

	}
	public void ExitInstructions(){
		Camera.main.GetComponent<Blur> ().enabled = false;
		controlScreen.SetActive (false);

		playButt.SetActive (true);
		aboutButt.SetActive (true);
		controlButt.SetActive (true);
		quitButt.SetActive (true);
	}
	public void OpenAbout(){
		Camera.main.GetComponent<Blur> ().enabled = true;
		aboutScreen.SetActive (true);

		playButt.SetActive (false);
		aboutButt.SetActive (false);
		controlButt.SetActive (false);
		quitButt.SetActive (false);
	}
	public void CloseAbout(){
		Camera.main.GetComponent<Blur> ().enabled = false;
		aboutScreen.SetActive (false);

		playButt.SetActive (true);
		aboutButt.SetActive (true);
		controlButt.SetActive (true);
		quitButt.SetActive (true);
	}
	public void QuitGame(){
		Application.Quit();
	}
}
