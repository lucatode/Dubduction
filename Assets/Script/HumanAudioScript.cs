﻿using UnityEngine;
using System.Collections;

public class HumanAudioScript : MonoBehaviour {

	public AudioClip[] clips;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public AudioClip getClip(int i){
		return clips[i];
	}
}
