using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeLive : MonoBehaviour {


	static bool once = false;
	// Use this for initialization
	void Awake () {
		if (!once) {
			GameObject.DontDestroyOnLoad (gameObject);
			once = true;
		} else {
			GameObject.Destroy (gameObject);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
