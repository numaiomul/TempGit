using UnityEngine;
using System.Collections;

public class Level1ParticleEmmiter : MonoBehaviour {

	public ParticleSystem particleForCamera;
	public Vector3 startPosition;
	public GameObject canon;

	private void Awake () {
		particleForCamera = Instantiate (particleForCamera.gameObject).GetComponent <ParticleSystem> ();
		particleForCamera.transform.position = startPosition;
		canon.SetActive(false);
		Invoke ("SetOff", particleForCamera.duration/2);
	}

	private void SetOff () {
		canon.SetActive(true);
		enabled = false;
	}
}
