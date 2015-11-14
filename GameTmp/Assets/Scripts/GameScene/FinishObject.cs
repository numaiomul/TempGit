using UnityEngine;
using System.Collections;

public class FinishObject : MonoBehaviour {

	public void OnTriggerEnter2D(Collider2D _col) {
		Debug.Log("here");
		if (_col.tag == "Projectile") {
			_col.attachedRigidbody.isKinematic = true;
			GlobalDefines.gameEndScreen.GameWon();
		}
	}
}
