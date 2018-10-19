using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour {

	public GameObject warning;
	public Button cancelHandle;
	public Button quitHandle;

	void Start() {
		Button cancel = cancelHandle.GetComponent<Button>();
		Button quit = quitHandle.GetComponent<Button>();

		cancel.onClick.AddListener(CancelQuit);
		quit.onClick.AddListener(QuitGame);
	}

	public void ClickExit () {
		warning.SetActive(true);
	}

	void CancelQuit(){
		warning.SetActive(false);
	}

	void QuitGame(){
		Application.Quit();
	}
}
