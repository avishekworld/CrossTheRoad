using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogJump : MonoBehaviour {

	public Vector3 jumpVector;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Debug.DrawRay (transform.position, jumpVector, Color.blue);

		Vector3 projectedJumpVector = Vector3.ProjectOnPlane (jumpVector, Vector3.up);
		Debug.DrawRay (transform.position, projectedJumpVector, Color.green);

		float radian = Mathf.Deg2Rad * 90;
		Vector3 rotatedJumpVector = Vector3.RotateTowards (projectedJumpVector, Vector3.up, radian, 0);
		Debug.DrawRay (transform.position, rotatedJumpVector.normalized, Color.red);

		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Rigidbody> ().AddForce (jumpVector, ForceMode.VelocityChange);
		}
	}
}
