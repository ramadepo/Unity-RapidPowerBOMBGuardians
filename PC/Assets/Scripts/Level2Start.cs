using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level2Start : MonoBehaviour {

	public static float TheCount;
	Text theText;
	int Count;

	// Use this for initialization
	void Start () {
		TheCount = 10f;
		Count = 10;
		theText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Cut.haveCut!=2) {
			TheCount = TheCount - 1 * Time.deltaTime;
			if (TheCount <= 9 && TheCount > 8.5) {
				Count = 9;
				theText.text = Count.ToString ();
			} else if (TheCount <= 8 && TheCount > 7.5) {
				Count = 8;
				theText.text = Count.ToString ();
			} else if (TheCount <= 7 && TheCount > 6.5) {
				Count = 7;
				theText.text = Count.ToString ();
			} else if (TheCount <= 6 && TheCount > 5.5) {
				Count = 6;
				theText.text = Count.ToString ();
			} else if (TheCount <= 5 && TheCount > 4.5) {
				Count = 5;
				theText.text = Count.ToString ();
			} else if (TheCount <= 4 && TheCount > 3.5) {
				Count = 4;
				theText.text = Count.ToString ();
			} else if (TheCount <= 3 && TheCount > 2.5) {
				Count = 3;
				theText.text = Count.ToString ();
			} else if (TheCount <= 2 && TheCount > 1.5) {
				Count = 2;
				theText.text = Count.ToString ();
			} else if (TheCount <= 1 && TheCount > 0.5) {
				Count = 1;
				theText.text = Count.ToString ();
			} else if (TheCount <= 0 && Count != 0) {
				Count = 0;
				theText.text = Count.ToString ();
				gameObject.SetActive (false);
			}
		} else {
			gameObject.SetActive (false);
		}

	}
}
