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
			Application.OpenURL("https://www.facebook.com/dialog/share?app_id=744566825731864&display=page&href=https%3A%2F%2Fpbrpg.grapeking.com.tw%2Fshare%2FbodyBuilder.html&redirect_uri=https%3A%2F%2Fpbrpg.grapeking.com.tw%2Fshare%2Fshare-success.html");
		}
		else if(which==2){
			Application.OpenURL("https://www.facebook.com/dialog/share?app_id=744566825731864&display=page&href=https%3A%2F%2Fpbrpg.grapeking.com.tw%2Fshare%2FerrandBoy.html&redirect_uri=https%3A%2F%2Fpbrpg.grapeking.com.tw%2Fshare%2Fshare-success.html");
		}
		else if(which==3){
			Application.OpenURL("https://www.facebook.com/dialog/share?app_id=744566825731864&display=page&href=https%3A%2F%2Fpbrpg.grapeking.com.tw%2Fshare%2Fadventurer.html&redirect_uri=https%3A%2F%2Fpbrpg.grapeking.com.tw%2Fshare%2Fshare-success.html");
		}
		else if(which==4){
			Application.OpenURL("https://www.facebook.com/dialog/share?app_id=744566825731864&display=page&href=https%3A%2F%2Fpbrpg.grapeking.com.tw%2Fshare%2Fmagician.html&redirect_uri=https%3A%2F%2Fpbrpg.grapeking.com.tw%2Fshare%2Fshare-success.html");
		}
		else if(which==5){
			Application.OpenURL("https://www.facebook.com/dialog/share?app_id=744566825731864&display=page&href=https://pbrpg.grapeking.com.tw/share/princess.html&redirect_uri=https://pbrpg.grapeking.com.tw/share/share-success.html");
		}
		else if(which==6){
			Application.OpenURL("https://www.facebook.com/dialog/share?app_id=744566825731864&display=page&href=https%3A%2F%2Fpbrpg.grapeking.com.tw%2Fshare%2Floner.html&redirect_uri=https%3A%2F%2Fpbrpg.grapeking.com.tw%2Fshare%2Fshare-success.html");
		}
	}
}
