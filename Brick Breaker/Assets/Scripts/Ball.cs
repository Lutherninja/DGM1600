using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public GameObject paddle;

	private bool playing = false;

	private Vector3 paddleToBallVector; //distance from ball to paddle
	private Rigidbody2D rigid;


	void Start () {
		paddleToBallVector = this.transform.position - paddle.transform.position;
		rigid = this.GetComponent<Rigidbody2D> ();
		print ("rigid");

	}
	

	void Update () {
	
		if (playing == false) {

		this.transform.position = paddle.transform.position + paddleToBallVector; //the ball will follow the paddles position with the vector we made
			//if push button 
			if(Input.GetMouseButtonDown(0)){


				rigid.velocity = new Vector2 (4,20);
				playing = true;
			}

			//ball should start flying around the map.
			//playing = true
			
		}
	
	}
}
