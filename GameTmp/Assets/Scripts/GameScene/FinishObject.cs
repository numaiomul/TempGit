using UnityEngine;
using System.Collections;

public class FinishObject : MonoBehaviour {

	public void OnTriggerEnter2D(Collider2D _col) {
		if (Application.loadedLevelName == "Level6") {
			if (_col.tag == "ProjectileLevel6") {
				_col.attachedRigidbody.isKinematic = true;
				GlobalDefines.gameEndScreen.GameWon();
			}
		} else {
			if (_col.tag == "Projectile") {
				_col.attachedRigidbody.isKinematic = true;
				GlobalDefines.gameEndScreen.GameWon();
			}
		}
	}
}
