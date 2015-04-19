﻿using UnityEngine;
using System.Collections;

public class ScrollController : MonoBehaviour {


	public int ninjasSafe= 0;
	public int winNumber;
	public bool goNextLevel = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (ninjasSafe == winNumber) {
			print("Level completed!");
			ninjasSafe = 0;
			goNextLevel = true;
		}

		if (goNextLevel)
			Application.LoadLevel("Level2");
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "ninja" && !goNextLevel) {
			GetComponent<AudioSource>().Play();
			coll.collider.isTrigger = true;
			++ninjasSafe;
		}


	}

}