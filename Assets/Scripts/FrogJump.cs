using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogJump : MonoBehaviour {

	public float jumpAngle = 45;
	public float speed = 5;
	
	// Update is called once per frame
	void Update () {

		Camera camera = GetComponentInChildren<Camera> ();

		Debug.DrawRay (transform.position, camera.transform.forward, Color.blue);

		Vector3 projectedJumpDirection = Vector3.ProjectOnPlane (camera.transform.forward, Vector3.up);
		Debug.DrawRay (transform.position, projectedJumpDirection, Color.green);

		float radian = Mathf.Deg2Rad * jumpAngle;
		Vector3 unnormalizedRotatedJumpDirection = Vector3.RotateTowards (projectedJumpDirection, Vector3.up, radian, 0);

		Vector3 jumpDirection = unnormalizedRotatedJumpDirection.normalized * speed;
		Debug.DrawRay (transform.position, jumpDirection, Color.red);

		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Rigidbody> ().AddForce (jumpDirection, ForceMode.VelocityChange);
		}
	}
}
