using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour {

	public Button mainMenuBtn,resetBtn,nextBtn;

	public void Show (bool _main, bool _reset, bool _next) {
		gameObject.SetActive(true);
		mainMenuBtn.gameObject.SetActive(_main);
		resetBtn.gameObject.SetActive(_reset);
		nextBtn.gameObject.SetActive(_next);
	}
	public void Hide() {
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
