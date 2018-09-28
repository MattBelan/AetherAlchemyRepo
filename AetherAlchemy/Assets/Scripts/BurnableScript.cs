﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnableScript : MonoBehaviour {

    GameObject burnablePotion;
    Collider burnCollider;
    Collider potCollider;

	// Use this for initialization
	void Start () {
        burnCollider = GetComponentInChildren<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
        burnCollider = gameObject.GetComponentInChildren<Collider>();
        burnablePotion = GameObject.Find("PotionTest(Clone)");
        if (burnablePotion != null)
        {
            potCollider = burnablePotion.GetComponent<Collider>();
        }
        if (CheckIntersection())
        {
            GameObject.Find("RigidBodyFPSController").GetComponent<PlayerScript>().potList.Remove(burnablePotion);
            Destroy(burnablePotion);
            Destroy(gameObject);
        }
	}

    bool CheckIntersection()
    {
        if (burnablePotion == null)
        {
            return false;
        }
        if (burnCollider.bounds.Intersects(potCollider.bounds))
        {
            return true;
        }
        return false;
    }
}
