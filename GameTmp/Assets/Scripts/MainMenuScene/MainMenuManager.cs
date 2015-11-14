using UnityEngine;
using System.Collections;

public class MainMenuManager : MonoBehaviour {

    private MainMenuManager() {
        GlobalDefines.mainMenuScreen = this;

    }

    public void OnPlayButton() {
		this.gameObject.SetActive(false);
		GlobalDefines.levelSelectScreen.gameObject.SetActive(true);
        
    }

	public void OnToggleSound(bool _value) {
		GlobalDefines.soundOn = _value;
	}
	public void OnToggleMusic(bool _value) {
		GlobalDefines.musicOn = _value;
	}

}
