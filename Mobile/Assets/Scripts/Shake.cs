using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour {

	float Timer;
	bool up;
	// Use this for initialization
	void Start () {
		Timer = Time.time;
		up = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - Timer > 0.2) {
			if (up) {
				transform.position = new Vector3 (transform.position.x, transform.position.y - 2, transform.position.z);
				up = false;
			} else {
				transform.position = new Vector3 (transform.position.x, transform.position.y + 2, transform.position.z);
				up = true;
			}
			Timer = Time.time;
		}


	}
}
