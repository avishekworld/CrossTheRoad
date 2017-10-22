using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum LaneType
{
	Safe,
	Danger
}

public class LevelGenerator : MonoBehaviour {

	public GameObject[] safeLanes;
	public GameObject[] dangerLanes; 
	private LaneType lastLaneType = LaneType.Safe;
	private float safeLaneProbability = 0.2f;
	float maxZ = 500;

	void Start () {
		for (int i = 0; i < maxZ; i += 10) {
			CreateLand (i);
		}
	}

	void CreateLand(float z){
		GameObject lane;
		if (lastLaneType == LaneType.Safe) {
			if (Random.value <= safeLaneProbability) {
				lastLaneType = LaneType.Safe;
				lane = IntantiateLane (safeLanes);
			} else {
				lastLaneType = LaneType.Danger;
				lane = IntantiateLane (dangerLanes);
			}
		} else {
			lastLaneType = LaneType.Safe;
			lane = IntantiateLane (safeLanes);
		}
		lane.transform.SetParent (transform, false);
		lane.transform.Translate (new Vector3 (0, 0, z));
	}

	GameObject IntantiateLane(GameObject[] lanes){
		GameObject land = Instantiate (lanes [Random.Range (0, lanes.Length)]);
		return land;
	}
}
