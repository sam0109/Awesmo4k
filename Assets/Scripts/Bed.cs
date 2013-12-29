using UnityEngine;
using System.Collections;

public class Bed : MonoBehaviour {

	public GameObject Manny;
	public MannyStats MannyStats;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Interact") && Mathf.Abs(MannyStats.getPositionX() - this.transform.position.x) <= 2 ) {
			SleepInBed();
		}
	}
	void SleepInBed () {
		MannyStats.Sleeping();
	}
}
