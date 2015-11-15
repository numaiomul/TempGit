using UnityEngine;
using System.Collections;

public class PrefabLevelHolder : MonoBehaviour {

	public AudioSource[] music;
	public AudioSource[] sound;

	public float counter;

	void Awake() {
		GlobalDefines.levelMusic = music;
		GlobalDefines.LevelMusicToggle(GlobalDefines.musicOn);
		GlobalDefines.levelSound = sound;
		GlobalDefines.LevelSoundToggle(GlobalDefines.soundOn);

		Time.timeScale = 1f;
		counter = 50f;
	}

	void Update() {
		counter -= Time.deltaTime;
		GlobalDefines.gameEndScreen.timer.text = ((int)counter).ToString();
		if (counter < 0) {
			GlobalDefines.gameEndScreen.GameLost();

		}
	}
}
