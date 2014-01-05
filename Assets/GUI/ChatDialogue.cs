using UnityEngine;
using System.Collections;

public class ChatDialogue : MonoBehaviour {
	float timer;
	public Vector3 origPos;
	// Use this for initialization
	void Start () {
		timer = Time.time + 5;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = (new Vector3(.5f,.7f,0));
		if (timer <= Time.time)
			Destroy(gameObject);
	}
}
