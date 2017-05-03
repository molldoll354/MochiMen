using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScene : MonoBehaviour {

	public float loadTime;

	// Use this for initialization
	void Start () {
		Invoke ("LoadScene", loadTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LoadScene(){
		SceneManager.LoadScene ("PostMochiZone");
	}

}
