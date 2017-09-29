using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuFollewer : MonoBehaviour {

	//Camera camera;
	void Start () {
		//camera = transform.parent.GetComponentInChildren<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		Camera camera = transform.parent.GetComponentInChildren<Camera> ();
		Vector3 projectedLookDirection = Vector3.ProjectOnPlane (camera.transform.forward, Vector3.up);
		Quaternion targetRotation =  Quaternion.LookRotation (projectedLookDirection);
		transform.rotation = targetRotation;
	}
}
