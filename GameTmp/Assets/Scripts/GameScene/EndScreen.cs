using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour {

	private EndScreen() {
		GlobalDefines.gameEndScreen = this;
	}

	public Button mainMenuBtn,resetBtn,nextBtn;

	public void GameWon() {
		if (GlobalDefines.maxLevel == GlobalDefines.levelLoaded) {
			Show(true,true,false);
		}
		else {
			Show(true,true,true);
		}
	}
	public void GameLost() {
		Show(true,true,false);
	}

	private void Show (bool _main, bool _reset, bool _next) {
		gameObject.SetActive(true);
		mainMenuBtn.gameObject.SetActive(_main);
		resetBtn.gameObject.SetActive(_reset);
		nextBtn.gameObject.SetActive(_next);
	}
	private void Hide() {
		gameObject.SetActive(false);
	}

	public void OnMainMenu () {
		Application.LoadLevel("MainMenu");
	}
	public void OnReset() {
		Application.LoadLevel("GameScene");
	}
	public void OnNext() {
		GlobalDefines.levelLoaded++;
		Application.LoadLevel("GameScene");
	}


}
