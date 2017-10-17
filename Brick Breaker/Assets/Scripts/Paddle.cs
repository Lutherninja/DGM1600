using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	public float paddleHeight;

	private Transform paddleTrans;


	// Use this for initialization
	void Start () {
		paddleTrans = gameObject.GetComponent<Transform> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mousepos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		mousepos.y = paddleHeight;
		mousepos.z = 0;


		paddleTrans.position = mousepos;

	}

}
