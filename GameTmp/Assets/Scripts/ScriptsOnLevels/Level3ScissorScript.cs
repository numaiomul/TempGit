using UnityEngine;
using System.Collections;

public class Level3ScissorScript : MonoBehaviour {

	private bool wasAnimated = false;

	public Rigidbody2D ballonRigidbody;

	private void OnTriggerEnter2D () {
		if (!wasAnimated) {
			AnimateScissor ();
			wasAnimated = true;
			ballonRigidbody.isKinematic = false;
		}
	}

	private void AnimateScissor () {

	}
}
