using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class PlayerController : MonoBehaviour
	{


	public float moveSpeed;
	public GameObject projectile;
	public Transform shotPos;
	public float shotForce;
	public int health;
	public ParticleSystem Thruster;

	public float clockwise = 500.0f;
	public float counterClockwise = -500.0f;

	void Start ()
	{
	}


		void Update ()
		{ // figure out how to use force to move the ship. Use linear drag to fine tune the drag of the ship to slow it down.
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.up * moveSpeed * Time.deltaTime);
			Thruster.Emit (11);
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

		
			switch (health) {
				case 1: //do stuff; break; each case is like an if statement
				case 2:
				default:
					break;

				}


	}
}
