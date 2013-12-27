using UnityEngine;
using System.Collections;

public class Gun1 : MonoBehaviour {
	public Object bullet;
	public float projectileVelocity = 100f;
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			FireBullet();
		}
	}
	void FireBullet () {
		GameObject bulletClone = (GameObject) Instantiate(bullet, transform.position, transform.rotation);
		bulletClone.rigidbody2D.AddForce(transform.rotation * new Vector2(projectileVelocity, 0f));
		// You can also acccess other components / scripts of the clone
		//rocketClone.GetComponent<MyRocketScript>().DoSomething();
	}
}
