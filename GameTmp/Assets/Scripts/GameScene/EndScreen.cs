using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour {

	private EndScreen() {
		GlobalDefines.gameEndScreen = this;
	}

	public RawImage winMovie;
	public AudioSource winSource;
	public Image loseImg;
	public AudioSource loseSource;
	public Button mainMenuBtn, resetBtn, nextBtn, resumeBtn;
	public Text timer;

	public void GameWon() {
		Time.timeScale = 0f;
		winMovie.gameObject.SetActive(true);
		if (winMovie.mainTexture != null) {
			if ((winMovie.mainTexture as MovieTexture) != null) {
				(winMovie.mainTexture as MovieTexture).Stop();
				(winMovie.mainTexture as MovieTexture).Play();
				winSource.gameObject.SetActive(true);
			}
		}
		if (GlobalDefines.maxLevel == GlobalDefines.levelLoaded) {
			Show(true,true,false,false);
		}
		else {
			Show(true,true,true,false);
		}
		if (GlobalDefines.musicOn) {
			GlobalDefines.LevelMusicToggle(false);
		}
	}
	public void GameLost() {
		Time.timeScale = 0f;
		loseImg.gameObject.SetActive(true);
		loseSource.gameObject.SetActive(true);

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
		GlobalDefines.LevelMusicToggle(GlobalDefines.musicOn);
		Time.timeScale = 1f;
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
