using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueController : MonoBehaviour {

	public bool tutorial2;
	public bool tutorial3;

	void Update () {
		// Tutorials
		if (Input.GetKeyDown (KeyCode.A) && !tutorial2) {
			Fungus.Flowchart.BroadcastFungusMessage ("tutorial2");
			tutorial2 = true;
		}
		if (Input.GetKeyDown (KeyCode.S) && !tutorial3) {
			Fungus.Flowchart.BroadcastFungusMessage ("tutorial3");
			tutorial3 = true;
		}

		// Feedback
		if (MochiZone.score == 3) {
			Fungus.Flowchart.BroadcastFungusMessage ("feedback1");
		}
		if (MochiZone.score == 7) {
			Fungus.Flowchart.BroadcastFungusMessage ("feedback2");
		}
		if (MochiZone.score == 10) {
			Fungus.Flowchart.BroadcastFungusMessage ("feedback3");
		}


	}


}
