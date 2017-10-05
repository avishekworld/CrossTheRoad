using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour {

	CollisionObserver collisionObserver;

	void Start () {
		collisionObserver = FindObjectOfType<CollisionObserver> ();	
	}
	
	public void OnCollisionEnter(Collision collision){
		collisionObserver.OnCollision ();
	}
}
