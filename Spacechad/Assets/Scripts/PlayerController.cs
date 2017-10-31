using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class PlayerController : MonoBehaviour
	{
		public float moveSpeed = 10f;
		public float turnSpeed = 50f;


		void Update ()
		{
			if(Input.GetKey(KeyCode.UpArrow))
				transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

			if(Input.GetKey(KeyCode.DownArrow))
				transform.Translate(-Vector3.up * moveSpeed * Time.deltaTime);

			if(Input.GetKey(KeyCode.LeftArrow))
				transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

			if(Input.GetKey(KeyCode.RightArrow))
				transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
	}
}
