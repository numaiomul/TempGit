using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	public AudioSource audioRef;

	public void OnCollisionEnter2D(Collision2D _col) {
		audioRef.Play();
	}
}
