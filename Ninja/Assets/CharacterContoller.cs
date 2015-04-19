using UnityEngine;
using System.Collections;



public class CharacterContoller : MonoBehaviour {

	public float speed;
	public float jumpForce;
	private bool grounded = false;
	private Animator anim;
	private bool jump = false;

	void Awake(){
		anim = GetComponent<Animator> ();
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if( Input.GetButtonDown( "Jump" ) && grounded  ){
			jump = true;
		}

	}

	void FixedUpdate(){
		float h = Input.GetAxis ("Horizontal");
		print (h);

		if (h > 0) 
			anim.SetFloat ("speed", 1);
		else if (h < 0)
			anim.SetFloat ("speed", -1);
		else if (h == 0)
			anim.SetFloat ("speed", 0);
		




	}



}
