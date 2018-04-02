using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCut : MonoBehaviour {

	public GameObject luck;
	public GameObject unluck;
	public GameObject aaa;
	AudioSource audiosource;
	public AudioClip ss, fs;
	public static int successful;
	Image NowPicture;
	Transform tran;
	GameObject TheNext,TheAnother;
	bool theplay=false;

	// Use this for initialization
	void Start () {
		tran = GetComponent<Transform> ();
		NowPicture = GetComponent<Image> ();
		audiosource = GetComponent<AudioSource> ();
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
			GameObject.Destroy(GameObject.Find("Directional Light"));
			GameObject.Destroy(GameObject.Find("Directional Light"));
			unluck.SetActive (true);
			if (!theplay) {
				audiosource.clip = fs;
				audiosource.Play ();
				theplay = true;
			}

			TheAnother.SetActive (true);
		} else if (Cut.haveCut == 2) {
			if(successful==0){
				successful = 2;
				GameObject.Destroy(GameObject.Find("Directional Light"));
				GameObject.Destroy(GameObject.Find("Directional Light"));
				unluck.SetActive (true);
				audiosource.clip = fs;
				audiosource.Play ();
				TheAnother.SetActive (true);
			}
			else if(successful==1){
				GameObject.Destroy(GameObject.Find("Directional Light"));
				GameObject.Destroy(GameObject.Find("Directional Light"));
				luck.SetActive (true);
				if (!theplay) {
					audiosource.clip = ss;
					audiosource.Play ();
					theplay = true;
				}
				TheAnother.SetActive (true);
			}
		}
	}

	public void aanother(){
		aaa.SetActive (true);
		TheNext.SetActive (true);
	}
}
