using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickCount : MonoBehaviour {

	public static int TheCount;
	public Sprite[] MM;
	public Sprite[] NN;
	Image NowPicture;
	Transform tran;
	public static float TheTime;
	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		TheCount = 0;
		TheTime = 10.0f;
		audioSource = GetComponent<AudioSource> ();
		tran = GetComponent<Transform> ();
		NowPicture = GetComponent<Image> ();
		NowPicture.sprite = MM [10];

	}
	
	// Update is called once per frame
	void Update () {
		ChangePicture ();
		if (Level1Start.IsStart) {
			TheTime = TheTime - 1 * Time.deltaTime;
		}
	}

	public void AddCount(){
		if (TheTime > 0&&Level1Start.IsStart) {
			TheCount++;
		}

	}

	void ChangePicture(){
		if(TheTime>8.5f&&TheTime<=9.0f){
			NowPicture.sprite = MM [9];
			Debug.Log ("9");
		}
		else if(TheTime>7.5f&&TheTime<=8.0f){
			NowPicture.sprite = MM [8];
			Debug.Log ("8");
		}
		else if(TheTime>6.5f&&TheTime<=7.0f){
			NowPicture.sprite = MM [7];
			Debug.Log ("7");
		}
		else if(TheTime>5.5f&&TheTime<=6.0f){
			NowPicture.sprite = MM [6];
			Debug.Log ("6");
		}
		else if(TheTime>4.5f&&TheTime<=5.0f){
			NowPicture.sprite = MM [5];
			Debug.Log ("5");
		}
		else if(TheTime>3.5f&&TheTime<=4.0f){
			NowPicture.sprite = MM [4];
			Debug.Log ("4");
		}
		else if(TheTime>2.5f&&TheTime<=3.0f){
			NowPicture.sprite = MM [3];
			Debug.Log ("3");
		}
		else if(TheTime>1.5f&&TheTime<=2.0f){
			NowPicture.sprite = MM [2];
			Debug.Log ("2");
		}
		else if(TheTime>0.5f&&TheTime<=1.0f){
			NowPicture.sprite = MM [1];
			Debug.Log ("1");
		}
		else if(TheTime>-0.2f&&TheTime<=0.0f){
			NowPicture.sprite = MM [0];
			audioSource.Play ();
			Debug.Log ("0");
		}
		else if(TheTime>-0.3f&&TheTime<=-0.2f){
			NowPicture.sprite = NN [5];
			Debug.Log ("-1");
		}
		else if(TheTime>-0.4f&&TheTime<=-0.3f){
			NowPicture.sprite = NN [4];
			Debug.Log ("-2");
		}
		else if(TheTime>-0.5f&&TheTime<=-0.4f){
			NowPicture.sprite = NN [3];
			Debug.Log ("-3");
		}
		else if(TheTime>-0.5f&&TheTime<=-0.4f){
			NowPicture.sprite = NN [2];
			Debug.Log ("-4");
		}
		else if(TheTime>-0.5f&&TheTime<=-0.4f){
			NowPicture.sprite = NN [1];
			Debug.Log ("-5");
		}
		else if(TheTime>-0.6f&&TheTime<=-0.5f){
			tran.localScale = new Vector3 (4f, 28f, 14f);
			NowPicture.sprite = NN [0];
			Debug.Log ("-6");
			SceneManager.LoadScene ("SceneLevel2");
		}
	}
}
