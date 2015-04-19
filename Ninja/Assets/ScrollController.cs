using UnityEngine;
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
			print("GAME WON");
			ninjasSafe = 0;
			goNextLevel = true;
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "ninja" && !goNextLevel) {
			++ninjasSafe;
		}


	}

}
