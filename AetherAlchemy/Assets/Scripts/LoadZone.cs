using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadZone : MonoBehaviour {

	public string sceneName;

	public void LoadZones() {
		 SceneManager.LoadScene(sceneName);
	}
}
