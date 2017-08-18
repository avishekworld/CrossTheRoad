using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogJump : MonoBehaviour {

	public float jumpAngle = 45;
	public float jumpSpeed = 5;
	public float jumpGroundClearance = 2;
	public float jumpSpeedTolerance = 5;
	
	// Update is called once per frame
	void Update () {
		bool isGrounderd = Physics.Raycast (transform.position, -transform.up * jumpGroundClearance);
		float speed = GetComponent<Rigidbody> ().velocity.magnitude;
		bool isStationary = speed < jumpSpeedTolerance;
		Debug.DrawRay (transform.position, -transform.up * jumpGroundClearance, Color.red);
		if (GvrViewer.Instance.Triggered && isGrounderd && isStationary) {
			Camera camera = GetComponentInChildren<Camera> ();
			Vector3 projectedJumpDirection = Vector3.ProjectOnPlane (camera.transform.forward, Vector3.up);
			float radian = Mathf.Deg2Rad * jumpAngle;
			Vector3 unnormalizedRotatedJumpDirection = Vector3.RotateTowards (projectedJumpDirection, Vector3.up, radian, 0);
			Vector3 jumpDirection = unnormalizedRotatedJumpDirection.normalized * jumpSpeed;
			GetComponent<Rigidbody> ().AddForce (jumpDirection, ForceMode.VelocityChange);
		}
	}
}
