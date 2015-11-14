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
		Time.timeScale = 1f;
		gameObject.SetActive(false);
	}

	public void OnMainMenu () {
		Time.timeScale = 1f;
		Application.LoadLevel("MainMenu");
	}
	public void OnReset() {
		Time.timeScale = 1f;
		Application.LoadLevel("GameScene");
	}
	public void OnNext() {
		Time.timeScale = 1f;
		GlobalDefines.levelLoaded++;
		Application.LoadLevel("GameScene");
	}


}
