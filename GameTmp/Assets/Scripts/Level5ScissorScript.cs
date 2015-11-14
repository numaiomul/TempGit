using UnityEngine;
using System.Collections;

public class Level5ScissorScript : MonoBehaviour {

	public Rigidbody2D rigidbodyToRelease;

	private void OnCollisionEnter2D(Collision2D col) {
		if (col.transform.tag == "Projectile") {
			rigidbodyToRelease.isKinematic = false;;
		}
	}
}
