﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour {

	public float lifetime;
	public float Speed;
	public int health;



	void Update () {

		lifetime -= Time.deltaTime;
		if (lifetime <= 0) {
			Destroy (this.gameObject);
		}
	
		//transform.Translate (Vector3.up * Speed * Time.deltaTime);



	}
	void OnCollisionEnter2D (Collision2D collider) {
		health--;


		if (health <= 0) {
			Destroy (this.gameObject);
		
		}
	
	}


}


