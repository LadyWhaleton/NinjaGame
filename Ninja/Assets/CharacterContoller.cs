using UnityEngine;
using System.Collections;



public class CharacterContoller : MonoBehaviour {

	public float Movespeed;
	public float jumpForce;
	private bool grounded = false;
	private Animator anim;
	private bool jump = false;
	bool isMoving;
	private float previousVelocity;
	private float currentVelocity;



	void Awake(){
		anim = GetComponent<Animator> ();
	}

	// Use this for initialization
	void Start () {

		previousVelocity = 0;
		currentVelocity = 0;

	}

	// Update is called once per frame
	void Update () {

		if( Input.GetButtonDown( "Jump" ) && grounded  ){
			jump = true;
		}

	}

	void flip(){
	}

	void FixedUpdate(){
		float h = Input.GetAxis ("Horizontal");
		transform.Translate (Vector3.right * h * Movespeed*Time.deltaTime);

		if (h > 0) { 
			anim.SetFloat ("speed", 1);

		}
		if (h < 0)
			anim.SetFloat ("speed", -1);

		if (h == 0) {
			anim.SetFloat ("speed", 0);
		}
	}



}
