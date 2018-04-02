using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCut : MonoBehaviour {

	public GameObject luck;
	public GameObject unluck;
	public GameObject aaa;
	public static int successful;
	Image NowPicture;
	Transform tran;
	GameObject TheNext,TheAnother;

	// Use this for initialization
	void Start () {
		tran = GetComponent<Transform> ();
		NowPicture = GetComponent<Image> ();
		TheNext = GameObject.Find ("GoToNext");
		TheNext.SetActive (false);
		TheAnother = GameObject.Find ("Another");
		TheAnother.SetActive (false);
		luck.SetActive (false);
		unluck.SetActive (false);
		successful = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Level2Start.TheCount > 0 && Cut.haveCut != 2) {
			
		} else if (Level2Start.TheCount <= 0) {
			unluck.SetActive (true);
			TheAnother.SetActive (true);
		} else if (Cut.haveCut == 2) {
			if(successful==0){
				successful = 2;
				unluck.SetActive (true);
				TheAnother.SetActive (true);
			}
			else if(successful==1){
				luck.SetActive (true);
				TheAnother.SetActive (true);
			}
		}
	}

	public void aanother(){
		aaa.SetActive (true);
		TheNext.SetActive (true);
	}
}
