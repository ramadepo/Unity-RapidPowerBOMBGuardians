using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LetStart : MonoBehaviour {

	public void ChangeScene(string sceneName){
		SceneManager.LoadScene (sceneName);
	}

	public void ChangeSceneS(string sceneName){
		SceneManager.LoadScene (sceneName);
		AudioSource TheMus;
		TheMus = GetComponent<AudioSource> ();
		TheMus.mute = true;

	}

	public void SelectScene(){
		if (ShowCut.successful==1) {
			if (ClickCount.TheCount > 120) {
				SceneManager.LoadScene ("Result1");
			} else if (ClickCount.TheCount <= 120 && ClickCount.TheCount > 60) {
				SceneManager.LoadScene ("Result3");
			} else {
				SceneManager.LoadScene ("Result5");
			}
		} else {
			if (ClickCount.TheCount > 120) {
				SceneManager.LoadScene ("Result2");
			} else if (ClickCount.TheCount <= 120 && ClickCount.TheCount > 60) {
				SceneManager.LoadScene ("Result4");
			} else {
				SceneManager.LoadScene ("Result6");
			}
		}
	}

}
