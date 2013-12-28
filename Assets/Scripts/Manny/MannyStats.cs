using UnityEngine;
using System.Collections;

public class MannyStats : MonoBehaviour {

	public float health = 100;
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		health = health - Time.deltaTime;
		if (health <= 0)
			Application.LoadLevel ("Death");
	}
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Health") {
			health = Mathf.Min (health + 50, 100);
			Destroy(coll.gameObject);
		}
	}
	public void Sleeping(){
		anim.SetBool ("Sleeping", true);
		if (Input.GetKeyDown ("space") || Input.GetKeyDown ("a") || Input.GetKeyDown ("d")) {
			anim.SetBool ("Sleeping", false);
		}
	}
	public float getPositionX(){
		return transform.position.x;
	}

}
