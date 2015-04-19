using UnityEngine;
using System.Collections;

public class ScrollController : MonoBehaviour {


	public int ninjasSafe= 0;
	public int winNumber;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (ninjasSafe == winNumber) {
			print("GAME WON");
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "ninja") {
			++ninjasSafe;
		}


	}

}
