using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {
	void OnTriggerStay2D(Collider2D other){
		if(Input.GetKeyDown("e")){
			Application.LoadLevel ("Level1");
		}
	}
}
