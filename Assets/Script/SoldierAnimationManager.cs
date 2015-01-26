﻿using UnityEngine;
using System.Collections;

public class SoldierAnimationManager : MonoBehaviour {

	public Animator animator;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void idleAnimation(bool v){
		animator.SetBool ("idle", v);
	}

	public void attackAnimation(bool v){
		animator.SetBool ("attack", v);
	}

	public void reloadAnimation(bool v){
		animator.SetBool ("reload", v);
	}

	public void destroyAnimation(bool v){
		animator.SetBool ("destroy", v);
	}

}
