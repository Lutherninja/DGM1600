using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class PlayerController : MonoBehaviour
	{


	public float moveSpeed = 10f;
	public float turnSpeed = 50f;
	public GameObject projectile;
	public Transform shotPos;
	public float shotForce;


		void Update ()
		{
			if(Input.GetKey(KeyCode.W))
				transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

			if(Input.GetKey(KeyCode.S))
				transform.Translate(-Vector3.up * moveSpeed * Time.deltaTime);

			if(Input.GetKey(KeyCode.A))
				transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

			if(Input.GetKey(KeyCode.D))
				transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

		if (Input.GetButtonUp ("Fire1")) 
		{
			GameObject shot = Instantiate (projectile, shotPos.position, shotPos.rotation) as GameObject;
			//shotPos.AddForce(shotPos.forward = shot(Force);
		}
	}
}
