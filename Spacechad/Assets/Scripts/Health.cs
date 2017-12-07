using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public const int maxHealth = 1;
	public int currentHealth = maxHealth;
	public GameObject explosionEffect;
		

	public void TakeDamage(int amount)
	{
		currentHealth -= amount;
		if (currentHealth  <= 0) 
		
		{
			currentHealth = 0;
			Debug.Log ("Dead!");
			Destroy (gameObject);
			Instantiate (explosionEffect, transform.position, Quaternion.identity);
		}
	}
}