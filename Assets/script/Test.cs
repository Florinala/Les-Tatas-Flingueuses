﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	public Animator myAnim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("f")){
			myAnim.SetBool("Reussite", true);
		}

		if (Input.GetKeyDown("j")){
			myAnim.SetBool("Reussite", false);
		}
	}
}
