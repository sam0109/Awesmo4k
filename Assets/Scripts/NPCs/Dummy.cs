using UnityEngine;
using System.Collections;

public class Dummy : MonoBehaviour {
	public GameObject text;
	GameObject dialogue;
	bool dialogueOpen = false;
	float timer;
	// Use this for initialization
	void Start () {
		timer = Time.time + 5;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= timer)
			dialogueOpen = false;
	}
	void OnTriggerStay2D(Collider2D player){
		if(player.gameObject.tag == "Player" && Input.GetKeyDown("e") && dialogueOpen == false){
			dialogue = (GameObject)Instantiate(text, Camera.main.WorldToViewportPoint(transform.position), Quaternion.identity);
			dialogueOpen = true;
			timer = Time.time + 5;
			CreateMenuText();
		}
	}
	void OnTriggerEnter2D(Collider2D player){
		if(player.gameObject.tag == "Player" && Input.GetKeyDown("e") && dialogueOpen == false){
			dialogue = (GameObject)Instantiate(text, Camera.main.WorldToViewportPoint(transform.position), Quaternion.identity);
			dialogueOpen = true;
			timer = Time.time + 5;
			CreateMenuText();
		}
	}
	void CreateMenuText(){
		dialogue.guiText.text = "I'm a dummy, hit me!";
		dialogue.GetComponent<ChatDialogue>().origPos = transform.position;
	}
}
