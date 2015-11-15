using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Snow : MonoBehaviour {

	public GameObject snowFlake;

	public Transform minToInstantiate;
	public Transform maxToInstantiate;
	public float posYToDestroy;

	private List<GameObject> snowFlakes;

	private void Awake () {
		snowFlakes = new List<GameObject> ();
	}

	private IEnumerator Start () {
		while (true) {
			InstantiateSnowFlake ();
			yield return new WaitForSeconds(0.3f);
		}
	}

	private void LateUpdate () {
		for (int i = 0; i < snowFlakes.Count; i++) {
			if (snowFlakes[i].transform.position.y < posYToDestroy) {
				GameObject snowFlakeToDestroy = snowFlakes[i];
				snowFlakes.RemoveAt (i);
				Destroy (snowFlakeToDestroy);
				i--;
			}
		}
	}

	private void InstantiateSnowFlake () {
		snowFlake = Instantiate (snowFlake) as GameObject;
		float posX = Random.Range (minToInstantiate.position.x, maxToInstantiate.position.x);
		float posY = Random.Range (minToInstantiate.position.y, maxToInstantiate.position.y);
		snowFlake.transform.position = new Vector3 (posX, posY, -2f);
		snowFlake.transform.localScale = Vector3.one * Random.Range (0.05f, 0.15f);
		snowFlake.GetComponent <Rigidbody2D> ().gravityScale = Random.Range (0.01f, 0.08f);
		snowFlake.name = "snowFlake";
		snowFlakes.Add (snowFlake);
	}
}
