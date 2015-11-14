using UnityEngine;
using System.Collections;

public class CreditsMenuManager : MonoBehaviour
{

    private CreditsMenuManager()
    {
        GlobalDefines.creditsMenuScreen = this;
    }
    public void OnBackButton() {
        GlobalDefines.mainMenuScreen.gameObject.SetActive(true);
        GlobalDefines.creditsMenuScreen.gameObject.SetActive(false);
    }
}
