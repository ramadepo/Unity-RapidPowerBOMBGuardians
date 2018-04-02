using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BreakPoint : MonoBehaviour {


	int which=0;

	// Use this for initialization
	void Start () {
		Scene scene=SceneManager.GetActiveScene();

		if (scene.name == "Result1") {
			which = 1;
		}
		else if(scene.name == "Result2"){
			which = 2;
		}
		else if(scene.name == "Result3"){
			which = 3;
		}
		else if(scene.name == "Result4"){
			which = 4;
		}
		else if(scene.name == "Result5"){
			which = 5;
		}
		else if(scene.name == "Result6"){
			which = 6;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void share(){
		if (which==1) {
			Application.OpenURL("https://www.facebook.com/share.php?u=https://pbrpg.grapeking.com.tw/share/bodyBuilder.html");
		}
		else if(which==2){
			Application.OpenURL("https://www.facebook.com/share.php?u=https://pbrpg.grapeking.com.tw/share/errandBoy.html");
		}
		else if(which==3){
			Application.OpenURL("https://www.facebook.com/share.php?u=https://pbrpg.grapeking.com.tw/share/adventurer.html");
		}
		else if(which==4){
			Application.OpenURL("https://www.facebook.com/share.php?u=https://pbrpg.grapeking.com.tw/share/magician.html");
		}
		else if(which==5){
			Application.OpenURL("https://www.facebook.com/share.php?u=https://pbrpg.grapeking.com.tw/share/princess.html");
		}
		else if(which==6){
			Application.OpenURL("https://www.facebook.com/share.php?u=https://pbrpg.grapeking.com.tw/share/loner.html");
		}
	}
}
