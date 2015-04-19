using UnityEngine;
using System.Collections;



public class CharacterContoller : MonoBehaviour {

	public float Movespeed;
	public float jumpForce;
	private bool grounded = false;
	private Animator anim;
	private bool jump = false;


	bool isMoving;


	void Awake(){
		anim = GetComponent<Animator> ();
	}

	// Use this for initialization
	void Start () {
	

	}

	// Update is called once per frame
	void Update () {

		// GetComponent<Rigidbody2D>().velocity.
		if (!grounded && GetComponent<Rigidbody2D>().velocity.y == 0)
		{
			grounded = true;
			print ("on ground");

		}

		if( Input.GetButtonDown( "Jump" ) && grounded  ){
			jump = true;
			grounded = false;
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
