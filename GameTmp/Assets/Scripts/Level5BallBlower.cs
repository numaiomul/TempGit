using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level5BallBlower : MonoBehaviour {

	Collider2D blowerCollider;
	public List<GameObject> balls;

	private void Awake () {
		SetBalls ();
		blowerCollider = GetComponent <Collider2D> ();
	}

	private void FixedUpdate () {
		SetBalls ();
	}

	private void SetBalls () {
		List<GameObject> list = ArrayToList (GameObject.FindGameObjectsWithTag ("Projectile"));
		foreach (GameObject l in list) {
			if (balls.IndexOf (l) == -1) {
				balls.Add (l);
			}
		}
	}

	private void Update () {
		for (int i = 0; i < balls.Count; i++) {
			Rigidbody2D ballRgidbody = balls[i].transform.GetComponent<Rigidbody2D> ();
			if (blowerCollider.bounds.Contains (balls[i].transform.position)) {
				ballRgidbody.gravityScale = Mathf.Lerp (ballRgidbody.gravityScale, -0.6f, 4.5f * Time.deltaTime);
			} else {
				ballRgidbody.gravityScale = Mathf.Lerp (ballRgidbody.gravityScale, 1.0f, 2.5f * Time.deltaTime);
			}
		}
	}

	private List<GameObject> ArrayToList (GameObject[] array) {
		List<GameObject> list = new List<GameObject>();
		for (int i = 0; i < array.Length; i++) {
			list.Add (array[i]);
		}
		return list;
	}
}
