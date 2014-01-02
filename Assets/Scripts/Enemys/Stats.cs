using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour {
	public float health = 100F;
	public GameObject damageCounter;
	
	void damageText(float points){
		GameObject gui = (GameObject)Instantiate(damageCounter, Camera.main.WorldToViewportPoint(transform.position),Quaternion.identity);
		gui.guiText.text = points.ToString();
		gui.GetComponent<damageText>().originalTransform = transform.position;
	}
	
	void damageEffect(float damageDealt){
		//todo: make shit red
		damageText(damageDealt);
	}
	void Damage(float[] damageAmt){
		health -= damageAmt[0];
		rigidbody2D.AddForce(new Vector2(damageAmt[1] * 100, 0));
		damageEffect(damageAmt[0]);
	}
	void Start(){
	
	}
	void Update() {
		print (health);
		if (health <= 0){
			Destroy(gameObject);
		}
	}
}
