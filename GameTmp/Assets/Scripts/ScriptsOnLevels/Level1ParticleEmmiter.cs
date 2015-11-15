using UnityEngine;
using System.Collections;

public class Level1ParticleEmmiter : MonoBehaviour {

	public ParticleSystem particleForCamera;
	public Vector3 startPosition;
	public GameObject canon;

	public ParticleSystem particleForPresent;
	public Vector3 particleForePresentStartPosition;

	private void Awake () {
		particleForCamera = Instantiate (particleForCamera.gameObject).GetComponent <ParticleSystem> ();
		particleForCamera.transform.position = startPosition;
		particleForPresent = Instantiate (particleForPresent.gameObject).GetComponent <ParticleSystem> ();
		particleForPresent.transform.position = particleForePresentStartPosition;
		canon.SetActive(false);
		Invoke ("SetOff", particleForCamera.duration/2);
	}

	private void SetOff () {
		canon.SetActive(true);
		enabled = false;
	}
}
