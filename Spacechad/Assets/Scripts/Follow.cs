using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

	public Transform objectToFollow;
	public float zOffset;

	void Update () {
		Vector3 myPos = objectToFollow.position;

		myPos.z = zOffset;
	
		gameObject.transform.position = myPos;
	}
}
