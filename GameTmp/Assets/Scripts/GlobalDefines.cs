using UnityEngine;
public static class GlobalDefines {
	public const int maxLevel = 6;
	public static int levelLoaded = 1;

	public static bool soundOn,musicOn;

    //MainMenu
    public static MainMenuManager mainMenuScreen;
	public static LevelSelectPanel levelSelectScreen;

	//GameScene
	public static EndScreen gameEndScreen;
}
