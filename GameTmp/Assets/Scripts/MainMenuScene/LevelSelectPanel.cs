using UnityEngine;
using System.Collections;

public class LevelSelectPanel : MonoBehaviour {

	private LevelSelectPanel() {
		GlobalDefines.levelSelectScreen = this;
	}

	public void OnLevelSelect(int _level) {
		GlobalDefines.levelLoaded = (byte)_level;
		Application.LoadLevel("GameScene");
	}
	public void OnBack() {
		this.gameObject.SetActive(false);
		GlobalDefines.mainMenuScreen.gameObject.SetActive(true);
	}
}
