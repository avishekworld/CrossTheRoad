using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VechicleMovement : MonoBehaviour {

	public float velocity = 10;
	// Use this for initialization
	void Start () {
		
	}

	void FixedUpdate () {
		GetComponent<Rigidbody> ().MovePosition (transform.position - Vector3.right * velocity * Time.deltaTime);
	}
}
