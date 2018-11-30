using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemGetNoteBehavior : MonoBehaviour {
	[SerializeField] private GameObject pausePanel;
	private Button potionPage;

	public void openBounce(){
		pausePanel.SetActive(true);
		potionPage = GameObject.Find("Button_Potions").GetComponent<Button>();
		potionPage.onClick.Invoke();
		potionPage = GameObject.Find("to-bounce").GetComponent<Button>();
		potionPage.onClick.Invoke();
	}

	public void openPush(){
		pausePanel.SetActive(true);
		potionPage = GameObject.Find("Button_Potions").GetComponent<Button>();
		potionPage.onClick.Invoke();
		potionPage = GameObject.Find("to-bounce").GetComponent<Button>();
		potionPage.onClick.Invoke();
		potionPage = GameObject.Find("to-push").GetComponent<Button>();
		potionPage.onClick.Invoke();
	}
}
