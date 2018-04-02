using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Intro : MonoBehaviour {

	public GameObject TheIntro;

	float thetime;
	bool IsShown;
	// Use this for initialization
	void Start () {
		IsShown = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (IsShown) {
			Level2Start.TheCount = thetime;
		}
	}

	public void BeClicked(){
		if (!IsShown) {
			thetime = Level2Start.TheCount;
			TheIntro.SetActive (true);
			IsShown = true;
		} else {
			TheIntro.SetActive (false);
			IsShown = false;
		}
	}
}
