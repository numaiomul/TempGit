using UnityEngine;
using System.Collections;

public class OptionsMenuManager : MonoBehaviour {

    private OptionsMenuManager() {
        GlobalDefines.optionsMenuScreen = this;
    }
    public void SoundOnButton() {

    }
    public void SoundOffButton() {

    }
    public void OnBackButton() {
        GlobalDefines.mainMenuScreen.gameObject.SetActive(true);
        GlobalDefines.optionsMenuScreen.gameObject.SetActive(false);
    }

}
