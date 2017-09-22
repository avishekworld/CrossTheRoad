using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogJump : MonoBehaviour {

	public float jumpAngle = 45;
	public float[] jumpSpeeds = {4, 5 , 6};
	int collisionCounter = 0;
	int jumpCounter;

	void OnCollisionEnter(Collision other){
		collisionCounter++;
	}

	void OnCollisionExit(Collision other){
		collisionCounter--;
	}
	
	// Update is called once per frame
	void Update () {
		bool isGrounderd = collisionCounter > 0;

		if (isGrounderd) {
			jumpCounter = 0;
		}

		if (GvrViewer.Instance.Triggered && jumpCounter < jumpSpeeds.Length) {
			Camera camera = GetComponentInChildren<Camera> ();
			Vector3 projectedJumpDirection = Vector3.ProjectOnPlane (camera.transform.forward, Vector3.up);
			float radian = Mathf.Deg2Rad * jumpAngle;
			Vector3 unnormalizedRotatedJumpDirection = Vector3.RotateTowards (projectedJumpDirection, Vector3.up, radian, 0);
			Vector3 jumpDirection = unnormalizedRotatedJumpDirection.normalized * jumpSpeeds[jumpCounter];
			GetComponent<Rigidbody> ().AddForce (jumpDirection, ForceMode.VelocityChange);
			jumpCounter++;
		}
	}
}
