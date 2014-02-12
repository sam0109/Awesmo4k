using UnityEngine;
using System.Collections;

public class SkyMover : MonoBehaviour {
	public GameObject Manny;
	float oldX;
	float oldY;
	public float xParallaxFactor = 2;
	public float yParallaxFactor = 2;
	// Use this for initialization
	void Start () {
		transform.position = Manny.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector2((Manny.transform.position.x - oldX) / xParallaxFactor, (Manny.transform.position.y - oldY) / yParallaxFactor);
		oldX = transform.position.x;
		oldY = transform.position.y;
	}
	
}
