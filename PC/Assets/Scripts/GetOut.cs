using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetOut : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DoIt(){
		GameObject.Find ("Before").SetActive (false);
		gameObject.SetActive (false);
	}
}
