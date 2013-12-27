using UnityEngine;
using System.Collections;

public class DeathScreen : MonoBehaviour {

	public GUIStyle button;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI() {
		GUI.Label(new Rect (Screen.width/2 - 75, Screen.height/2 - 150, 150 , 100), "You Died!", button);
		if (GUI.Button (new Rect (Screen.width/2 - 75, Screen.height/2 - 50, 150, 100), "Start", button))
			Application.LoadLevel ("Level1");
		
	}
}
