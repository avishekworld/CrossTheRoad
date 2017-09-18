using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehiclePlacer : MonoBehaviour {

	public GameObject prefab;
	public int meanTime = 1;
	public int minimumInterval = 2;
	public double nextInterval = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextInterval) {
			PlaceVehicle ();
			nextInterval = Time.time + minimumInterval + -Mathf.Log (Random.value) * meanTime;
		}
	}

	void PlaceVehicle(){
		GameObject car = Instantiate (prefab, transform.position, transform.rotation, transform);
	}
}
