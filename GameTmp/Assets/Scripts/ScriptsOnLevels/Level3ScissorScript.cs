using UnityEngine;
using System.Collections;

public class Level3ScissorScript : MonoBehaviour {

	private bool wasTriggered = false;
	private bool wasAnimated = false;
	private float counter = 0f;
	public const float END_TIME = 0.5f;
	public Transform scis1,scis2;
	public Rigidbody2D ballonRigidbody;

	private void OnTriggerEnter2D () {
		Debug.Log("here");
		if (!wasTriggered) {
			AnimateScissor ();
			wasTriggered = true;
			ballonRigidbody.isKinematic = false;
		}
	}

	void Update() {
		counter += Time.deltaTime;
		if (counter > END_TIME){ counter = END_TIME;
			this.enabled = false;
			wasAnimated = true;
		}
		scis1.localEulerAngles = new Vector3(0,0, Mathf.Lerp(30,5,counter*2));
		scis2.localEulerAngles = new Vector3(0,0, Mathf.Lerp(-30,-5,counter*2));
	}

	private void AnimateScissor () {
		this.enabled = true;
	}
}
