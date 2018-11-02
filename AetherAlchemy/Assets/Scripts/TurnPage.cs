using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnPage : MonoBehaviour {

	public GameObject currentPage;
	public GameObject nextPage;

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
}
