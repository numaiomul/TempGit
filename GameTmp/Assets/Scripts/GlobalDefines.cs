using UnityEngine;
public static class GlobalDefines {
	public const int maxLevel = 4;
	public static int levelLoaded = 1;

	private static bool _soundOn = true;
	public static bool soundOn {
		get {
			return _soundOn;
		}
		set {
			soundOn = value;
			LevelSoundToggle(soundOn);
		}
	}
	private static bool _musicOn = true;
	public static bool musicOn {
		get {
			return _musicOn;
		}
		set {
			musicOn = value;
			LevelMusicToggle(musicOn);
		}
	}

    //MainMenu
    public static MainMenuManager mainMenuScreen;
	public static LevelSelectPanel levelSelectScreen;

	//GameScene
	public static EndScreen gameEndScreen;
	public static AudioSource[] levelMusic;
	public static AudioSource[] levelSound;

	public static void LevelMusicToggle(bool _value) {
		foreach (AudioSource audio in levelMusic) {
			audio.mute = !_value;
		}
	}
	public static void LevelSoundToggle(bool _value) {
		foreach (AudioSource audio in levelSound) {
			audio.mute = !_value;
		}
	}
}
