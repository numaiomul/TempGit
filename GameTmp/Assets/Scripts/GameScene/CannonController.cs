using UnityEngine;
using System.Collections;
using DG.Tweening;

public class CannonController : MonoBehaviour {

	[SerializeField] private int minEulerAngleZ;
	[SerializeField] private int maxEulerAngleZ;
	[SerializeField] private float timeRotate;

	private void Awake () {
		RotateToZMax ();
	}

	private void Update () {
		if (Input.GetMouseButtonDown (0)) {
			transform.DOKill ();
		}
	}

	private void RotateToZMin () {
		transform.DORotate (new Vector3 (transform.localEulerAngles.x, transform.localEulerAngles.y, minEulerAngleZ), 
		                    timeRotate).OnComplete (RotateToZMax);
	}

	private void RotateToZMax () {
		transform.DORotate (new Vector3 (transform.localEulerAngles.x, transform.localEulerAngles.y, maxEulerAngleZ), 
		                    timeRotate).OnComplete (RotateToZMin);;
	}
 }
