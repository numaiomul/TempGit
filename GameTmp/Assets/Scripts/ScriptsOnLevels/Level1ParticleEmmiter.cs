using UnityEngine;
using System.Collections;

public class Level1ParticleEmmiter : MonoBehaviour {
	public ParticleSystem particleForPresent;
	public Vector3 particleForePresentStartPosition;

	private void Awake () {
		particleForPresent = Instantiate (particleForPresent.gameObject).GetComponent <ParticleSystem> ();
		particleForPresent.transform.position = particleForePresentStartPosition;
	}
}
