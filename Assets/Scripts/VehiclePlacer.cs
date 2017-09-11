using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehiclePlacer : MonoBehaviour {

	public GameObject prefab;
	public int vechilePlacerMinInterval = 1;
	public int vehiclePlacerMaxInterval = 4;
	public double nextInterval = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextInterval) {
			PlaceVehicle ();
			nextInterval = Time.time + Random.Range (vechilePlacerMinInterval, vehiclePlacerMaxInterval);
		}
	}

	void PlaceVehicle(){
		GameObject car = Instantiate (prefab, transform.position, transform.rotation, transform);
	}
}
