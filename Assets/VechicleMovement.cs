using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VechicleMovement : MonoBehaviour {

	public float velocity = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-velocity * Time.deltaTime, 0, 0);
	}
}
