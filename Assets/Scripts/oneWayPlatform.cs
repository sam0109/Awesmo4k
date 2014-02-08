using UnityEngine;
using System.Collections;

public class oneWayPlatform : MonoBehaviour {
	public BoxCollider2D colliderPlatform;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {  
	}

	void OnTriggerStay2D(Collider2D other){
		colliderPlatform.enabled=false;
	}
	void OnTriggerExit2D(Collider2D other){
		colliderPlatform.enabled=true; 
	}
}
