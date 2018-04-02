using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Start : MonoBehaviour {

	public static bool IsStart = false;

	// Use this for initialization
	void Start () {
		IsStart = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LevelStart(){
		IsStart = true;
		gameObject.SetActive (false);
		GameObject.Find ("StartImage").SetActive (false);
	}
}
