﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoRight : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (FADEIN.CanStart) {
			if (transform.position.x <= 383) {
				transform.position = new Vector3 (transform.position.x + 1f, transform.position.y, transform.position.z);
			}
		}

	}
}
