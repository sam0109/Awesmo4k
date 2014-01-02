using UnityEngine;
using System.Collections;

public class ArmPointer : MonoBehaviour {
	public GameObject manny;
	bool direction = true;
	Animator anim;

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

		if (mousePos.x > 0f) {
			direction = true;
			transform.localPosition = new Vector3 (0,0,-1);
			transform.localScale =  new Vector3 (1,1,1);
		}
		else {
			direction = false;
			transform.localPosition = new Vector3(0,0,0);
			transform.localScale =  new Vector3 (1,-1,1);
		}
		anim.SetBool("Direction", direction);
	}
}
