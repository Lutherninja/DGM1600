﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autodestroy : MonoBehaviour {

	private void Start()
	{
		Destroy(gameObject, GetComponent<ParticleSystem>().duration);
	}
}