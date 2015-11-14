using UnityEngine;
using System.Collections;

public class PrefabLevelHolder : MonoBehaviour {

	public AudioSource[] music;
	public AudioSource[] sound;
	void Awake() {
		GlobalDefines.levelMusic = music;
		GlobalDefines.LevelMusicToggle(GlobalDefines.musicOn);
		GlobalDefines.levelSound = sound;
		GlobalDefines.LevelSoundToggle(GlobalDefines.soundOn);

		Time.timeScale = 1f;
	}
}
