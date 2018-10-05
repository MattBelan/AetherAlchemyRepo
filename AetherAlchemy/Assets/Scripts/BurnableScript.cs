using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnableScript : MonoBehaviour {

    GameObject burnablePotion;
    Collider burnCollider;
    Collider potCollider;
    GameObject player;
   
    AudioSource burn;

	// Use this for initialization
	void Start () {
        burnCollider = GetComponentInChildren<Collider>();
        burn = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        player = GameObject.Find("RigidBodyFPSController");
        burnCollider = gameObject.GetComponentInChildren<Collider>();
        burnablePotion = GameObject.Find("PotionTest(Clone)");
        if (burnablePotion != null)
        {
            potCollider = burnablePotion.GetComponent<Collider>();
        }
        /*
        if (CheckIntersection())
        {
            GameObject.Find("RigidBodyFPSController").GetComponent<PlayerScript>().potList.Remove(burnablePotion);
            Destroy(burnablePotion);
            Destroy(gameObject);
        }
        */
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

    void OnCollisionEnter(Collision pot)
    {
        if(burnablePotion == pot.gameObject)
        {
            GameObject.Find("BurnSound").GetComponent<AudioSource>().Play();
            GameObject.Find("ShatterSound").GetComponent<AudioSource>().Play();
            GameObject.Find("RigidBodyFPSController").GetComponent<PlayerScript>().potList.Remove(burnablePotion);
            Destroy(burnablePotion);
            Destroy(gameObject);
        }
    }

}
