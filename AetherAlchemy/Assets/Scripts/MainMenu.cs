using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	public Scene sceneName;
	void StartGame() {
		SceneManager.LoadScene(sceneName, LoadSceneMode.single);
	}
}
