using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogJump : MonoBehaviour {

	public float jumpAngle = 45;
	public float jumpSpeed = 5;
	int collisionCounter = 0;

	void OnCollisionEnter(Collision other){
		collisionCounter++;
	}

	void OnCollisionExit(Collision other){
		collisionCounter--;
	}
	
	// Update is called once per frame
	void Update () {
		bool isGrounderd = collisionCounter > 0;
		if (GvrViewer.Instance.Triggered && isGrounderd) {
			Camera camera = GetComponentInChildren<Camera> ();
			Vector3 projectedJumpDirection = Vector3.ProjectOnPlane (camera.transform.forward, Vector3.up);
			float radian = Mathf.Deg2Rad * jumpAngle;
			Vector3 unnormalizedRotatedJumpDirection = Vector3.RotateTowards (projectedJumpDirection, Vector3.up, radian, 0);
			Vector3 jumpDirection = unnormalizedRotatedJumpDirection.normalized * jumpSpeed;
			GetComponent<Rigidbody> ().AddForce (jumpDirection, ForceMode.VelocityChange);
		}
	}
}
