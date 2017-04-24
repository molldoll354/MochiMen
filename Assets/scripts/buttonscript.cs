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

	public GameObject controlScreen;
	public GameObject aboutScreen;
	public GameObject mainCamera;

	public void PlayScene(){
		SceneManager.LoadScene ("dialogueTest");
	}
	public void OpenInstructions(){
		Camera.main.GetComponent<Blur> ().enabled = true;
		controlScreen.SetActive (true);
	}
	public void ExitInstructions(){
		Camera.main.GetComponent<Blur> ().enabled = false;
		controlScreen.SetActive (false);
	}
	public void OpenAbout(){
		Camera.main.GetComponent<Blur> ().enabled = true;
		aboutScreen.SetActive (true);
	}
	public void CloseAbout(){
		Camera.main.GetComponent<Blur> ().enabled = false;
		aboutScreen.SetActive (false);
	}
	public void QuitGame(){
		Application.Quit();
	}
}
