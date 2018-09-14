using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	//player references and variables
	public GameObject potion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			ThrowPotion();
		}
	}

	void ThrowPotion(){
		Instantiate (potion, this.gameObject.transform);
	
	}
}
