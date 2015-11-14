using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour {

	private EndScreen() {
		GlobalDefines.gameEndScreen = this;
	}

	public Button mainMenuBtn, resetBtn, nextBtn, resumeBtn;

	public void GameWon() {
		Time.timeScale = 0f;
		if (GlobalDefines.maxLevel == GlobalDefines.levelLoaded) {
			Show(true,true,false,false);
		}
		else {
			Show(true,true,true,false);
		}
	}
	public void GameLost() {
		Time.timeScale = 0f;
		Show(true,true,false,false);
	}
	public void GamePaused() {
		Time.timeScale = 0f;
		Show(true,true,false,true);
	}
	public void GameResumed() {
		Time.timeScale = 1f;
		Hide();
	}

	private void Show (bool _main, bool _reset, bool _next, bool _resume) {
		gameObject.SetActive(true);
		mainMenuBtn.gameObject.SetActive(_main);
		resetBtn.gameObject.SetActive(_reset);
		nextBtn.gameObject.SetActive(_next);
		resumeBtn.gameObject.SetActive(_resume);
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
