using UnityEngine;
using System.Collections;

public class MainMenuManager : MonoBehaviour {

    private MainMenuManager()
    {
        GlobalDefines.mainMenuScreen = this;

    }

    public void OnPlayButton() {
        GlobalDefines.levelLoaded = 1;
        Application.LoadLevel("GameScene");

    }
    public void OnOptionsButton() {
        this.gameObject.SetActive(false);
        GlobalDefines.optionsMenuScreen.gameObject.SetActive(true);

    }
    public void OnCreditsButton() {
        this.gameObject.SetActive(false);
        GlobalDefines.creditsMenuScreen.gameObject.SetActive(true);
    }
}
