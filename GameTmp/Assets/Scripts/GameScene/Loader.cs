using UnityEngine;
using System.Collections;

public class Loader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Instantiate(Resources.Load("Levels/Level"+GlobalDefines.levelLoaded)as GameObject);
		Destroy(this);
	}

}
