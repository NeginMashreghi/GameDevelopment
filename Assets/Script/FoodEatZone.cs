﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodEatZone : MonoBehaviour {

	[SerializeField]
	Transform spawnPoint = null;

	public void OnCollisionEnter2D(Collision2D other) {

		other.transform.position = spawnPoint.position;

		Rigidbody2D rb = other.gameObject.GetComponent<Rigidbody2D> ();
		if (rb) { 
			rb.velocity = Vector2.zero;
		}
	}
}
