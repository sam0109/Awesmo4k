using UnityEngine;
using System.Collections;

public class ArmPointer : MonoBehaviour {
	public GameObject manny;
	bool direction = true;
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = manny.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		//rotation
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = 5.23f;
		
		Vector3 objectPos = Camera.main.WorldToScreenPoint (transform.position);
		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;
		
		float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

		if (direction == false && mousePos.x > 0f) {
			direction = true;
		}
		else if(direction == true && mousePos.x < 0f){
			direction = false;
		}
		anim.SetBool("Direction", direction);
	}
}
