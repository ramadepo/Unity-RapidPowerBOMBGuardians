using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Analyze : MonoBehaviour {


	float lastTIme;
	// Use this for initialization
	void Start () {
		lastTIme = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - lastTIme >= 5) {
			gameObject.SetActive (false);
		}
	}
}
