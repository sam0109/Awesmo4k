using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy(gameObject, 1F);
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Enemy") {
			coll.gameObject.SendMessage ("Damage", 2f);
		}
		Destroy (gameObject, .05f);
	}
}
