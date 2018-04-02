using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleRotate : MonoBehaviour {

	RectTransform tran;
	public float zz;
	// Use this for initialization
	void Start () {
		tran = GetComponent<RectTransform> ();
	}
	
	// Update is called once per frame
	void Update () {
		tran.Rotate (new Vector3 (0f, 0f, -1*zz));
	}
}
