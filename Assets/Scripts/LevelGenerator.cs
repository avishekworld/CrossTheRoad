using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	public GameObject []prefabs;
	float maxZ = 500;

	void Start () {
		for (int i = 0; i < maxZ; i += 10) {
			CreateLand (Random.Range (0, 3), i);
		}
	}

	void CreateLand(int landIndex,float z){
		GameObject land = Instantiate (prefabs [landIndex]);
		land.transform.SetParent (transform, false);
		land.transform.Translate (new Vector3 (0, 0, z));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
