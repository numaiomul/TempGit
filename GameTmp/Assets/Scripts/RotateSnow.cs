using UnityEngine;
using System.Collections;

public class RotateSnow : MonoBehaviour {

	private Vector3 rotateTo;

	private void Awake () {
		switch (Random.Range (0,3)) {
		case 0:
			rotateTo = Vector3.up;
			break;
		case 1:
			rotateTo = Vector3.forward;
			break;
		case 2:
			rotateTo = Vector3.back;
			break;
		}
	}

	private void Update () {
		transform.Rotate (rotateTo);
	}
}
