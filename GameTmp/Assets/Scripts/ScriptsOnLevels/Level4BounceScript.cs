using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Level4BounceScript : MonoBehaviour {

	private const string COLLIDER_TO_BOUNCE_TAG = "Bounce";
	private PhysicsMaterial2D physicMaterial;
	private float initialBounciness;
	private bool gateIsClosed = false;
	public Transform gate;
	public float closeGateToY;
	public float timeToCloseGate;

	private void Awake () {
		physicMaterial = new PhysicsMaterial2D ();
		physicMaterial.friction = 0.2f;
		physicMaterial.bounciness = 1.4f;
		GetComponent<Collider2D>().sharedMaterial = physicMaterial;
	}

	private void OnCollisionEnter2D (Collision2D col) {
		switch (col.transform.tag) {
		case COLLIDER_TO_BOUNCE_TAG :
			physicMaterial.bounciness = 1.4f;
			break;
		case "Projectile":
			//CloseGate ();
			physicMaterial.bounciness = 0.0f;
			break;
		default:
			physicMaterial.bounciness = 0.0f;
			GetComponent<Rigidbody2D> ().velocity /= 5;
			break;
		}
	}

	private void CloseGate () {
		if (!gateIsClosed) {
			gateIsClosed = true;
			gate.DOLocalMoveY (closeGateToY, timeToCloseGate).SetEase (Ease.OutBounce);
		}
	}
}
