using UnityEngine;
using System.Collections;

public class MannyMover : MonoBehaviour {
	
	Vector2 up = new Vector2(0f,800f);
	Vector2 right = new Vector2(5000f,0f);
	Vector2 left = new Vector2(-5000f,0f);
	public float accelSpeed = 1f;
	public float moveSpeed = 100;
	bool onGround = false;
	Animator anim;

	void Start () {
		anim = GetComponent<Animator>();
	}

	void Update () {

		if(Input.GetKeyDown("space") && onGround == true){
			rigidbody2D.AddForce(up);
			onGround = false;
		}
		if(Input.GetKey("a") && rigidbody2D.velocity.x > -moveSpeed){
			rigidbody2D.AddForce(left * accelSpeed * Time.deltaTime);
		}
		if(Input.GetKey("s")){

		}
		if(Input.GetKey("d") && rigidbody2D.velocity.x < moveSpeed){
			rigidbody2D.AddForce(right * accelSpeed * Time.deltaTime);
		}
		anim.SetFloat("Speed", rigidbody2D.velocity.x);
		anim.SetBool("Jumping", !onGround);
		anim.speed = (Mathf.Max(Mathf.Abs(rigidbody2D.velocity.x * .2F), .1F));
	}
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Ground")
			onGround = true;
		
	}
}
