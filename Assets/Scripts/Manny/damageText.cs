using UnityEngine;
using System.Collections;

public class damageText : MonoBehaviour {

	public Color color = new Color(1f,0f,0f,1f);
	public float scroll = 0.05f;  // scrolling velocity
	public float duration = 1.5f; // time to die
	public float alpha;
	public Vector3 originalTransform;
	float scrolled = 0;

	// Use this for initialization
	void Start () {
		guiText.material.color = color;
		alpha = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		if (alpha > 0f){
			scrolled += scroll*Time.deltaTime;
			transform.position = Camera.main.WorldToViewportPoint(new Vector3(originalTransform.x, originalTransform.y, originalTransform.z));
			transform.position += new Vector3(0, scrolled, 0);
			alpha -= Time.deltaTime/duration; 
			color.a = alpha;
			guiText.material.color = color;
		}
		else {
			Destroy(gameObject);
		}
	}
}
