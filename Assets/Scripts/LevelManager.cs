using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadNextScene(){
		int currentScene = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (currentScene + 1);
	}

	public void ReloadScene(){
		int currentScene = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (currentScene);
	}

	public void Quit(){
		Debug.Log ("Game Will Quit");
		Application.Quit ();
	}
}
