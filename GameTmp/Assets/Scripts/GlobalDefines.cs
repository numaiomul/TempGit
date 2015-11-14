using UnityEngine;
public static class GlobalDefines {
	public const byte maxLevel = 6;
	public static byte levelLoaded = 1;

    //MainMenu
    public static MainMenuManager mainMenuScreen;
	public static LevelSelectPanel levelSelectScreen;
    public static OptionsMenuManager optionsMenuScreen;
    public static CreditsMenuManager  creditsMenuScreen;

	//GameScene
	public static EndScreen gameEndScreen;
}
