using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cut : MonoBehaviour {

	public static int haveCut;
	public static int Iswho1;
	public static int Iswho2;
	int i,j;
	bool still;
	int whoAmI;
	public Sprite theEndPicture;
	Image Picture;
	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		Picture = GetComponent<Image> ();
		audioSource = GetComponent<AudioSource>();
		haveCut = 0;
		still = true;
		i = Random.Range (0,1000);
		j = Random.Range (0,1000);
		Iswho1 = i % 6;
		Iswho2 = j % 6;
		if (gameObject.name == "1") {
			whoAmI = 0;
		} else if (gameObject.name == "2") {
			whoAmI = 1;
		} else if (gameObject.name == "3") {
			whoAmI = 2;
		} else if (gameObject.name == "4") {
			whoAmI = 3;
		} else if (gameObject.name == "5") {
			whoAmI = 4;
		} else if (gameObject.name == "6") {
			whoAmI = 5;
		}
	}
	
	// Update is called once per frame
	void Update(){
		if (ShowCut.successful == 2) {
			still = false;
		}
	}

	public void BeCut(){
		if(still){
			audioSource.Play ();
			still = false;
			Picture.sprite = theEndPicture;
			if (whoAmI == Iswho1 || whoAmI == Iswho2) {
				ShowCut.successful = 0;
				haveCut = 2;
				gameObject.SetActive (false);
				Debug.Log (ShowCut.successful);
			} else {
				haveCut++;
			}
		}

	}

}
