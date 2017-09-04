using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGeneretor : MonoBehaviour {

	public GameObject treePrefab;
	public int minTrees = 5;
	public int maxTrees = 15;

	void Start () {
		int trees = Random.Range (minTrees, maxTrees);
		for (int i = 0; i < trees; i++) {
			CreateTree ();
		}
	}

	void CreateTree(){
		GameObject tree = Instantiate (treePrefab);
		tree.transform.parent = transform;
		tree.transform.localPosition = new Vector3 (Random.Range (-50, 50), 0, Random.Range (-5, 5));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
