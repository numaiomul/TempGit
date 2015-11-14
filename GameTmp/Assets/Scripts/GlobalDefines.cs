using UnityEngine;
public static class GlobalDefines {
	public const int maxLevel = 6;
	public static int levelLoaded = 1;

    //MainMenu
    public static MainMenuManager mainMenuScreen;
	public static LevelSelectPanel levelSelectScreen;
    public static OptionsMenuManager optionsMenuScreen;
    public static CreditsMenuManager  creditsMenuScreen;

	//GameScene
	public static EndScreen gameEndScreen;
}
