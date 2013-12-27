using UnityEngine;
using System.Collections;

public class MannyCam : MonoBehaviour {

	public Texture2D healthBarFilled;
	public GameObject Manny;
	public GUIStyle healthBar;
	float health;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		health = Manny.GetComponent<MannyStats>().health / 100;
	}

	void OnGUI() {
		GUI.BeginGroup (new Rect (25, Screen.height - 25, healthBarFilled.width * health, healthBarFilled.height));
			GUI.Box(new Rect (0,0, healthBarFilled.width, healthBarFilled.height), healthBarFilled, healthBar);
		GUI.EndGroup ();
	}
}
