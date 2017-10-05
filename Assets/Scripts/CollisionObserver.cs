using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionObserver : MonoBehaviour {

	public GameObject gameOverMenuCanvas;

	public void OnCollision(){
		gameOverMenuCanvas.SetActive (true);
	}
}
