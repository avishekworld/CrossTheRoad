using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGeneretor : MonoBehaviour {

	public GameObject treePrefab;

	void Start () {
		CreateTree();
		CreateTree();
		CreateTree();
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
