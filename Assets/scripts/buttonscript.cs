using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class buttonscript : MonoBehaviour {

	public Button playButton;
	public Button aboutButton;
	public Button controlsButton;
	public Button quitButton;

	public GameObject controlScreen;
	public GameObject aboutScreen;


	public void PlayScene(){
		SceneManager.LoadScene ("dialogueTest");
	}

	public void ExitInstructions(){
		controlScreen.SetActive (false);
	}

	public void OpenInstructions(){
		controlScreen.SetActive (true);
	}

	public void QuitGame(){
		Application.Quit();
	}

	public void OpenAbout(){
		aboutScreen.SetActive (true);
	}

	public void CloseAbout(){
		aboutScreen.SetActive (false);
	}
}
