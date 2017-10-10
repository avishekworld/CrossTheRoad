using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionObserver : MonoBehaviour {

	public GameObject gameOverMenuCanvas;
	public GameObject gazeIcon;

	public void OnCollision(){
		gameOverMenuCanvas.SetActive (true);
		GetComponent<Rigidbody> ().isKinematic = true;
		gazeIcon.SetActive (true);
	}
}
