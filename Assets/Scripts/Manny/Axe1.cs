using UnityEngine;
using System.Collections;

public class Axe1 : MonoBehaviour {
	public float[] damage = new float[2];
	bool dealtDamage = false;
	float swingCD = 1;
	float timeStamp = 0;
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1") && Time.time >= timeStamp){
			dealtDamage = false;
			timeStamp = Time.time + swingCD;
			anim.SetBool("Swing", true);
		}
		else //if(Time.time >= timeStamp)
			anim.SetBool("Swing", false);
	}
	void OnTriggerStay2D(Collider2D enemy){
		print ("in");
		if(enemy.gameObject.tag == "Enemy" && anim.GetCurrentAnimatorStateInfo(0).IsName("SwingAxe1") && dealtDamage == false){
			enemy.gameObject.SendMessage("Damage", damage);
			dealtDamage = true;
		}
	}
	void OnTriggerEnter2D(Collider2D enemy){
		if(enemy.gameObject.tag == "Enemy" && anim.GetCurrentAnimatorStateInfo(0).IsName("SwingAxe1") && dealtDamage == false){
			enemy.gameObject.SendMessage("Damage", damage);
			dealtDamage = true;
		}
	}
}
