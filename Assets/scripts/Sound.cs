﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {
	public static Sound me;
	public GameObject audSource;
	public AudioSource[] audSources = new AudioSource[32]; // 32 is max number of audiosources that can play at once

	void Awake(){
		me = this;
		for (int i = 0; i < audSources.Length; i++) {
			audSources [i] = (Instantiate (audSource, Vector3.zero, Quaternion.identity, this.transform) as GameObject).GetComponent<AudioSource> ();
		}
	}

	void Start () {
	}

	public void PlaySound(AudioClip snd, float vol){
		int sNum = GetSourceNum ();
		audSources [sNum].clip = snd;
		audSources [sNum].volume = vol;
		audSources [sNum].Play ();
	}

	public int GetSourceNum(){
		for (int i = 0; i < audSources.Length; i++) {
			if (!audSources [i].isPlaying) {
				return i;
			}
		}
		return 0;
	}
}
