using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class PlayerController : MonoBehaviour
	{


	public float moveSpeed = 10f;
	public GameObject projectile;
	public Transform shotPos;
	public float shotForce;

	public float clockwise = 500.0f;
	public float counterClockwise = -500.0f;

		void Update ()
		{
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.up * moveSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (-Vector3.up * moveSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.Q)) {
			transform.Translate (Vector3.left * moveSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.E)) {
			transform.Translate (Vector3.right * moveSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (0, 0, Time.deltaTime * clockwise);
		} else if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (0, 0, Time.deltaTime * counterClockwise);
		}
	

		if (Input.GetButtonUp ("Fire1")) 
		{
			GameObject shot = Instantiate (projectile, shotPos.position, shotPos.rotation) as GameObject;
			shot.GetComponent<Rigidbody2D> ().AddForce (shotPos.up * shotForce);
			//shotPos.AddForce(shotPos.forward * shot(Force);
		}
	}
}
