using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	//player references and variables
	public GameObject potion;
    private bool firstIng;
    private bool secondIng;
    private bool potReady;

    // Use this for initialization
    void Start () {
        firstIng = false;
        secondIng = false;
        potReady = false;
	}
	
	// Update is called once per frame
	void Update () {
		

        if (Input.GetKeyDown("1") && !firstIng)
        {
            firstIng = true;
        }
        if (Input.GetKeyDown("2") && !secondIng)
        {
            secondIng = true;
        }

        if(firstIng && secondIng)
        {
            potReady = true;
        }

        if (Input.GetMouseButtonDown(0) && potReady)
        {
            ThrowPotion();
            firstIng = false;
            secondIng = false;
            potReady = false;
        }
    }

	void ThrowPotion(){
		Instantiate (potion, this.gameObject.transform);
	
	}
}
