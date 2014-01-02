using UnityEngine;
using System.Collections;

public class MannyCam : MonoBehaviour {

	public Texture2D healthBarFilled;
	public GameObject Manny;
	public GUIStyle healthBar;
	float health;
	MannyStats Stats;
	
	void Start () {
		Stats = Manny.GetComponent<MannyStats>();
	}
	
	void Update () {
		health = Stats.health / 100;
	}

	void OnGUI() {
		GUI.BeginGroup (new Rect (25, Screen.height - 25, healthBarFilled.width * health, healthBarFilled.height));
			GUI.Box(new Rect (0,0, healthBarFilled.width, healthBarFilled.height), healthBarFilled, healthBar);
		GUI.EndGroup ();
	}
}