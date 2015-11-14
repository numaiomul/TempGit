using UnityEngine;
using System.Collections;
using DG.Tweening;

public class CannonController : MonoBehaviour {

	[SerializeField] private int minEulerAngleZ;
	[SerializeField] private int maxEulerAngleZ;
	[SerializeField] private float timeRotate;

	[SerializeField] private float minPowerBar;
	[SerializeField] private float maxPowerBar;
	[SerializeField] private float timePowerBar;
	
	[SerializeField] private float maxForce;

	[SerializeField] private Rigidbody2D projectile;
	[SerializeField] private Transform powerBar;

	private void Awake () {
		RotateToZMax ();
	}

	private void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if (DOTween.IsTweening (transform)) {
				transform.DOKill ();
				MovePowerBarToMax ();
				powerBar.gameObject.SetActive (true);
			} else {
				float force = (powerBar.transform.localPosition.x + Mathf.Abs (minPowerBar))/(maxPowerBar - minPowerBar);
				LaunchTheProjectile (force * maxForce);
			}
		}
	}

	private void LaunchTheProjectile (float force) {
		projectile.gameObject.SetActive (true);
		projectile.AddForce (projectile.transform.right * force, ForceMode2D.Impulse);
		enabled = false;
		powerBar.DOKill ();
	}

	private void MovePowerBarToMin () {
		powerBar.DOLocalMoveX (minPowerBar, timePowerBar).SetEase (Ease.InOutSine).OnComplete (MovePowerBarToMax);
	}

	private void MovePowerBarToMax () {
		powerBar.DOLocalMoveX (maxPowerBar, timePowerBar).SetEase (Ease.InOutSine).OnComplete (MovePowerBarToMin);
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
