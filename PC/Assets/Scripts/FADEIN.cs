using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FADEIN : MonoBehaviour {


	public static bool CanStart = false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DoIt(){


		CanStart = true;
		GameObject.Find ("Before").SetActive (false);
		gameObject.SetActive (false);
	}
		
}
