using UnityEngine;
using System.Collections;

public class Level3SeaSaw : MonoBehaviour {

	public void OnCollisionEnter2D(Collision2D _col) {
		if (_col.gameObject.tag == "Ballon") {
			this.GetComponent<Rigidbody2D>().isKinematic = false;
		}
	}
}
