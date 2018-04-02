using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level1Intro : MonoBehaviour {

	public GameObject TheIntro;

	int theclickcount;
	float thetime;
	bool IsShown;
	// Use this for initialization
	void Start () {
		IsShown = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (IsShown) {
			ClickCount.TheCount = theclickcount;
			ClickCount.TheTime = thetime;
		}
	}

	public void BeClicked(){
		if (!IsShown) {
			theclickcount = ClickCount.TheCount;
			thetime = ClickCount.TheTime;
			TheIntro.SetActive (true);
			IsShown = true;
		} else {
			TheIntro.SetActive (false);
			IsShown = false;
		}
	}
}
