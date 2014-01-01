using UnityEngine;
using System.Collections;

public class MannyMover : MonoBehaviour {
	
	Vector2 up = new Vector2(0f,1000f);
	Vector2 right = new Vector2(8000f,0f);
	Vector2 left = new Vector2(-8000f,0f);
	public float accelSpeed = 1f;
	public float moveSpeed = 10f;
	public float jumpHeight = 1f;
	bool onGround = false;
	Animator anim;

	void Start () {
		anim = GetComponent<Animator>();
	}

	void Update () {

		if(Input.GetKeyDown("space") && onGround == true){
			rigidbody2D.AddForce(up * jumpHeight);
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

		if(rigidbody2D.velocity.y > .001)
			anim.SetInteger("Jumping", 1);
		else if (rigidbody2D.velocity.y < -.001)
			anim.SetInteger("Jumping", -1);
		else
			anim.SetInteger("Jumping", 0);

		anim.speed = (Mathf.Max(Mathf.Abs(rigidbody2D.velocity.x * .2F), .1F));
	}
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Ground")
			onGround = true;
		
	}
}
