using UnityEngine;
using System.Collections;

public class MainMenuManager : MonoBehaviour {
    public GameObject PlayButton;
    public GameObject OptionsButton;
    public GameObject CreditsButton;
	// Use this for initialization

    public void OnPlayButton() {
        GlobalDefines.levelLoaded = 1;
        Application.LoadLevel("GameScene");

    }
    public void OnOptionsButton() {
        this.gameObject.SetActive(false);
    }
    public void OnCreditsButton() {
        this.gameObject.SetActive(false);
    }
}
