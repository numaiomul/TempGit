﻿using UnityEngine;
using System.Collections;

public class MainMenuManager : MonoBehaviour {

    private MainMenuManager() {
        GlobalDefines.mainMenuScreen = this;

    }

    public void OnPlayButton() {
		this.gameObject.SetActive(false);
		GlobalDefines.levelSelectScreen.gameObject.SetActive(true);
        
    }
	public void OnEarlyAcces() {
		GlobalDefines.levelLoaded = 4;
		Application.LoadLevel("GameScene");
	}
	public void OnQuitButton() {
		Application.Quit();
	}

}
