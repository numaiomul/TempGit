using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.UI;

public class CannonController : MonoBehaviour {

	[SerializeField] private int minEulerAngleZ;
	[SerializeField] private int maxEulerAngleZ;
	[SerializeField] private float timeRotate;

	[SerializeField] private float minPowerBar;
	[SerializeField] private float maxPowerBar;
	[SerializeField] private float timePowerBar;
	
	[SerializeField] private float maxForce;

	[SerializeField] private Rigidbody2D projectile;
	[SerializeField] private Transform projectileStartPosition;
	[SerializeField] private Transform powerBar;

	[SerializeField] private float timeToRespawnAnotherProjectile;
	public AudioSource shootAudio;
	public AudioSource loadAudio;

	private Vector3 projScale;

	private Vector3 powerBarStartPosition;

	private void Awake () {
		projScale = new Vector3 ((transform.localScale.x/10),(transform.localScale.y/10),1);
		RotateToZMax ();
		powerBarStartPosition = powerBar.transform.localPosition;

	}

	private void Update () {
		if (Input.GetMouseButtonDown (0) && Time.timeScale != 0f && DOTween.IsTweening (transform)) {
			transform.DOKill ();
			MovePowerBarToMax ();
			loadAudio.Play();
			powerBar.gameObject.SetActive (true);
		}
		if (Input.GetMouseButtonUp(0) && Time.timeScale != 0f && DOTween.IsTweening (powerBar.transform)) {
			float force = (powerBar.transform.localPosition.x + Mathf.Abs (minPowerBar))/(maxPowerBar - minPowerBar);
			LaunchTheProjectile (force * maxForce);
			powerBar.gameObject.SetActive (false);
		}
	}
	private void RefreshProjectile () {
		powerBar.transform.localPosition = powerBarStartPosition;
		RotateToZMax ();
	}

	private void LaunchTheProjectile (float force) {
		GameObject projectileGO = (GameObject)Instantiate(projectile.gameObject,projectileStartPosition.position,Quaternion.identity) ;
		projectileGO.SetActive (true);
		projectileGO.transform.name = "Projectile";
		projectileGO.transform.localScale = projScale;
		projectile = projectileGO.GetComponent<Rigidbody2D> ();
		projectile.AddForce (transform.right * force, ForceMode2D.Impulse);
		powerBar.DOKill ();
		Invoke ("RefreshProjectile", timeToRespawnAnotherProjectile);
		shootAudio.Play();
		loadAudio.Stop();
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
		                    timeRotate).OnComplete (RotateToZMin);
	}
 }
