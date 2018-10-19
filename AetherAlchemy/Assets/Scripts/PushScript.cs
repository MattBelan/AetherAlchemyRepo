﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushScript : MonoBehaviour {

    public GameObject pushArea;
    GameObject player;
    PlayerScript ps;

    // Use this for initialization
    void Start () {
        player = GameObject.FindWithTag("Player");
        ps = player.GetComponent<PlayerScript>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Player")
        {
            Instantiate(pushArea, transform.position, transform.rotation);
            ps.potList.Remove(gameObject);
            Destroy(gameObject);
        }
    }
}
