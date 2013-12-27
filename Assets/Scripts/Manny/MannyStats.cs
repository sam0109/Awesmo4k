using UnityEngine;
using System.Collections;

public class MannyStats : MonoBehaviour {

	public float health = 100;
	// Use this for initialization
	void Start () {
	
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
}
