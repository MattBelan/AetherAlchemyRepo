using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGem : MonoBehaviour {

	public GameObject gem;
	public GameObject player;
	// private Collider playerCollider;
	// private Collider gemCollider;
	private Pause pauseScript;
	// Use this for initialization
	void Start(){
		pauseScript = player.GetComponent<Pause>();
		// playerCollider = player.GetComponent<Collider>();
		// gemCollider = gameObject.GetComponentInChildren<Collider>();
	}

	void OnCollisionEnter(Collision touch){
		if(touch.gameObject == player) {
			pauseScript.GemGet();
			gem.SetActive(false);
            player.GetComponent<PlayerScript>().PickUpGem();
		}
	}
}
