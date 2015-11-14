﻿using UnityEngine;
using System.Collections;

public class Level5WallBouncer : MonoBehaviour {

	private void OnCollisionEnter2D(Collision2D col) {
		if (col.transform.tag == "Projectile") {
			if (col.collider.sharedMaterial == null) {
				col.transform.GetComponent <CircleCollider2D> ().sharedMaterial = new PhysicsMaterial2D ();
			}
			col.transform.GetComponent <CircleCollider2D> ().sharedMaterial.friction = 0.2f;
			col.transform.GetComponent <CircleCollider2D> ().sharedMaterial.bounciness = 1.4f;
			col.transform.GetComponent <CircleCollider2D> ().radius = 7;
		}
	}
}
