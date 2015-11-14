﻿using UnityEngine;
public static class GlobalDefines {
	public const byte maxLevel = 2;
	public static byte levelLoaded = 1;

    //MainMenu
    public static MainMenuManager mainMenuScreen;
    public static OptionsMenuManager optionsMenuScreen;
    public static CreditsMenuManager  creditsMenuScreen;

	//GameScene
	public static EndScreen gameEndScreen;
}
