using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Level6Box : MonoBehaviour {

	public Transform toPos;
	public Level6Box pairBox;
	public float duration;

	private void OnTriggerEnter2D (Collider2D col) {
		if (col.transform.tag == "Projectile") {
			SetToghether ();
			pairBox.SetToghether ();
		}
	}

	public void SetToghether () {
		transform.DOMove (toPos.position, duration).SetEase (Ease.OutExpo);
		GetComponent <Collider2D> ().isTrigger = false;
		enabled = false;
	}
}
