using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnPage : MonoBehaviour {

	public GameObject currentPage;
	public GameObject nextPage;
	// public GameObject panelsClosingLeft;
	// public GameObject panelsClosingRight;
	// public GameObject panelsOpeningLeft;
	// public GameObject panelsOpeningRight;

	public void TurnPages() {
		currentPage.SetActive(false);
		nextPage.SetActive(true);
	}

	public void SubMenuTurnForward() {
		nextPage.SetActive(true);
	}

	public void SubMenuTurnBackward() {
		currentPage.SetActive(false);
	}
	//
	// public void OpenSavePanel() {
	// 	panelsClosingLeft.SetActive(false);
	// 	panelsClosingRight.SetActive(false);
	// 	panelsOpeningLeft.SetActive(true);
	// 	panelsOpeningRight.SetActive(true);
	// }
}
