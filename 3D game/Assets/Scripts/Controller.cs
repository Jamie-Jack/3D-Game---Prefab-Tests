using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	
	private Animator anim;
	public float moveSpeed = 0.5f;
	private CharacterController controller;
	public Camera cam;

	private float verticalVel;
	private float gravity = 15.0f;
	public float jumpForce = 10.0f;

		void Start () {

			controller = GetComponent<CharacterController>();
			anim = GetComponent<Animator>();
		}

		void Update () {
		Gravity ();
		transform.rotation = Quaternion.Euler (transform.rotation.eulerAngles.x, cam.transform.rotation.eulerAngles.y, cam.transform.rotation.eulerAngles.z);

			//get input key varaibles (between 0 and 1)
			var x = Input.GetAxis("Horizontal");
			var y = Input.GetAxis("Vertical");

			Move(x, y);
		 
			anim.SetBool("blocking",(Input.GetAxis("Fire2") ==1));


		
			//anim.SetBool("attack", (Input.GetAxis("Fire1") ==1));
		   // anim.SetBool("Macca", (Input.GetAxis("Macca") ==1));
		 //   anim.SetBool("Twerk", (Input.GetAxis("Twerk") ==1));
		   // anim.SetBool("Thriller", (Input.GetAxis("Thriller") ==1));

		if(Input.GetAxis("Jump") ==1) {
			anim.SetBool("jump",true);

		}
		else anim.SetBool("jump",false);

		}
		
		private void Move(float x, float y)
		{

			anim.SetFloat("posX", x);
			anim.SetFloat("posY", y);


			transform.Translate(Vector3.forward * y * Time.deltaTime * moveSpeed);
			transform.Translate(Vector3.right * x * Time.deltaTime * moveSpeed);

	}
	    private void Gravity(){

		Debug.Log (verticalVel);


		if (controller.isGrounded) {
			verticalVel = -gravity * Time.deltaTime;
			if (Input.GetAxis ("Jump") == 1) {
				verticalVel = jumpForce;
			}
		} else verticalVel -= gravity * Time.deltaTime;
			






		Vector3 MoveVector = new Vector3( 0, verticalVel, 0);
		controller.Move(MoveVector * Time.deltaTime);
	}

}